using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ShevkunenkoSite.Pages
{
    public class SandboxModel : PageModel
    {
        public void OnGet()
        {
            var message = HttpContext.Request.Host;

            var t = "t";
        }
    }
}
