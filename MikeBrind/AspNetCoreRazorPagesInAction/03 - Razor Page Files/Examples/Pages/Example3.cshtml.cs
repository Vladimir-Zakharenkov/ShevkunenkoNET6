using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Examples.Pages
{
    public class Example3Model : PageModel
    {
        [BindProperty]
        public string Name { get; set; }
    }
}
