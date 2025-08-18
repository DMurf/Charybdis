using AspNetCore.Authentication.Basic;
using Charybdis.Web.Models;
using Microsoft.Extensions.Options;

namespace Charybdis.Web.Middleware
{
    public class BasicUserValidationService : IBasicUserValidationService
    {
        private readonly ILogger<BasicUserValidationService> _logger;
        private readonly IOptions<BasicAuthOptions> _options;

        public BasicUserValidationService(ILogger<BasicUserValidationService> logger, IOptions<BasicAuthOptions> options)
        {
            _logger = logger;
            _options = options;
        }

        public async Task<bool> IsValidAsync(string username, string password)
        {
            try
            {
                var result = !_options.Value.IsEnabled || (username == _options.Value.UserName && password == _options.Value.Password);
                return await Task.FromResult(result);
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message);
                throw;
            }
        }
    }
}