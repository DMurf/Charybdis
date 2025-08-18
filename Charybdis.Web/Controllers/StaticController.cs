using Charybdis.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Charybdis.Web.Controllers
{
    public class StaticController : Controller
    {
        private readonly IOptions<AppSettingsOptions> _options;
        public StaticController(IOptions<AppSettingsOptions> options)
        {
            _options = options;
        }

        [Route("/cookies")]
        [HttpGet]
        public IActionResult Cookies()
        {
            return View();
        }

        [Route("/cookie-settings")]
        [HttpGet]
        public IActionResult CookiesSettings()
        {
            return View();
        }

        [Route("/cookie-settings")]
        [HttpPost]
        public IActionResult CookiesSettings(string id)
        {
            return View();
        }

        [Route("/accessibility")]
        [HttpGet]
        public IActionResult Accessibility()
        {
            return View();
        }

        [Route("/privacy")]
        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }


    }
}
