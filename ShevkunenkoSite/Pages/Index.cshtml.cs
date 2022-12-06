using Microsoft.AspNetCore.Http.Extensions;

namespace ShevkunenkoSite.Pages
{
    public class IndexModel : PageModel
    {
        private LinkGenerator linkGenerator;
        public IndexModel(LinkGenerator linkGenerator) => this.linkGenerator = linkGenerator;
        public string PathByPage { get; set; }

        public void OnGet()
        {
            //var message = HttpContext.Request.Host.Value;

            //var message2 = HttpContext.Request.Path.Value;

            PathByPage = linkGenerator.GetPathByPage(HttpContext.Request.Path)!;

            var wer = 1;
        }
    }
}


