using Microsoft.AspNetCore.Http.Extensions;

namespace ShevkunenkoSite.Pages
{
    public class IndexModel : PageModel
    {

        public void OnGet()
        {
            var message = HttpContext.Request.Host;

            var message2 = HttpContext.Request.Path;


            var t = "t";


        }
    }
}


