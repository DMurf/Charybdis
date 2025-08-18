namespace Charybdis.Web.Models
{
    public class RateLimitOptions
    {
        public bool IsEnabled { get; set; } = default!;
        public int RateLimitWindow { get; set; } = default!;
        public int RateLimitSubmissions { get; set; } = default!;
    }
}
