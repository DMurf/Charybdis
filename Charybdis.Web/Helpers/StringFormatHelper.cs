using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Charybdis.Web.Helpers
{
    public static class StringFormatHelper
    {
        public static string Percentify(this string input)
        {
            var dub = decimal.Parse(input);
            dub = dub * 100;
            return dub.ToString("0.##") + "%";
        }
    }
}
