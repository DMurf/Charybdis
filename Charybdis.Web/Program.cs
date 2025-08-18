using AspNetCore.Authentication.Basic;
using Charybdis.Core.Interfaces.Repositories;
using Charybdis.Core.Interfaces.Services;
using Charybdis.Core.Services;
using Charybdis.Infrastructure.Repositories;
using Charybdis.Infrastructure.Repositories.Generic;
using Charybdis.Web.Middleware;
using Charybdis.Web.Models;
using GovUk.Frontend.AspNetCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.RateLimiting;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Charybdis.Web;

public class Program
{
    [ExcludeFromCodeCoverage]
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddOptions();
        builder.Services.Configure<BasicAuthOptions>(builder.Configuration.GetSection("Authentication"));
        builder.Services.Configure<RateLimitOptions>(builder.Configuration.GetSection("RateLimiting"));
        builder.Services.Configure<AppSettingsOptions>(builder.Configuration.GetSection("AppSettings"));

        var enableLogin = builder.Configuration.GetValue<bool>("Authentication:IsEnabled");

        var rateLimit = new RateLimitOptions();
        builder.Configuration.GetSection("RateLimiting").Bind(rateLimit);

        var appSettings = new AppSettingsOptions();
        builder.Configuration.GetSection("AppSettings").Bind(appSettings);

        builder.Services.AddGovUkFrontend(options =>
        {

            options.Rebrand = true;
            options.GetCspNonceForRequest = context =>
            {
                return CSPHelper.RandomCharacters;
            };
        });

        builder.Services.AddControllersWithViews()
                .AddRazorOptions(options =>
                {
                    options.ViewLocationFormats.Add("/{0}.cshtml");
                });



        builder.Services.Configure<RequestLocalizationOptions>(options =>
        {
            options.DefaultRequestCulture = new Microsoft.AspNetCore.Localization.RequestCulture("en-GB");
            options.SupportedCultures = new List<CultureInfo> { new CultureInfo("en-GB") };
            options.RequestCultureProviders.Clear();
        });

        builder.Services.AddMvc();

        if (rateLimit?.IsEnabled == true)
        {
            builder.Services.AddRateLimiter(options =>
            {
                options.RejectionStatusCode = 429;
                options.AddFixedWindowLimiter("Web", options =>
                {
                    options.AutoReplenishment = true;
                    options.PermitLimit = rateLimit.RateLimitSubmissions;
                    options.Window = TimeSpan.FromMinutes(rateLimit.RateLimitWindow);
                });
            });
        }


        if (enableLogin)
        {
            builder.Services.AddAuthentication(BasicDefaults.AuthenticationScheme)
                .AddBasic<BasicUserValidationService>(options => { options.Realm = "Charybdis"; });

            builder.Services.AddAuthorizationBuilder()
                .SetFallbackPolicy(new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build());
        }


        builder.Services.AddScoped<IGenericRepository, GenericCSVRepository>();
        builder.Services.AddScoped<IGIASRepository, GIASRepository>();
        builder.Services.AddScoped<IEstablishmentCoreService, EstablishmentCodeService>();




        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment() || appSettings?.EnableDetailedErrors == true)
        {
            app.UseDeveloperExceptionPage(new DeveloperExceptionPageOptions { SourceCodeLineCount = 1 });
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        if (!appSettings.EnableDetailedErrors)
        {
            app.UseStatusCodePagesWithReExecute("/Error/{0}");
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();
        app.UseGovUkFrontend();

        app.UseAuthorization();

        //app.Use(async (context, next) =>
        //{
        //    context.Response.Headers.Append("Expect-CT", "max-age=86400, enforce");
        //    context.Response.Headers.Append("Referrer-Policy", "same-origin");
        //    context.Response.Headers.Append("Arr-Disable-Session-Affinity", "true");
        //    context.Response.Headers.Append("X-Content-Type-Options", "nosniff");
        //    context.Response.Headers.Append("X-Frame-Options", "DENY");
        //    context.Response.Headers.Append("X-Permitted-Cross-Domain-Policies", "none");
        //    context.Response.Headers.Append("X-XSS-Protection", "0");
        //    context.Response.Headers.Append("Strict-Transport-Security", "max-age=31536000;includeSubDomains; preload");

        //    context.Items["ScriptNonce"] = CSPHelper.RandomCharacters;

        //    context.Response.Headers.Append(
        //        "Content-Security-Policy",
        //        "base-uri 'self';"
        //        + "default-src 'self';"
        //        + "frame-ancestors 'none';"
        //        + "connect-src 'self' *.google-analytics.com *.analytics.google.com *.clarity.ms; child-src 'none';"
        //        + "frame-src 'none';"
        //        + "img-src 'self'"
        //        + "style-src 'self'"
        //        + "font-src 'self'"
        //        + $"script-src 'self' 'nonce-{context.Items["ScriptNonce"]} https://www.googletagmanager.com *.google-analytics.com https://*.clarity.ms;"
        //        );

        //    await next.Invoke();
        //});

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}
