namespace Charybdis.Web.Models
{
    public class BasicAuthOptions
    {
        public bool IsEnabled { get; set; } = default!;
        public string UserName { get; set; } = default!;
        public string Password { get; set; } = default!;

    }
}
