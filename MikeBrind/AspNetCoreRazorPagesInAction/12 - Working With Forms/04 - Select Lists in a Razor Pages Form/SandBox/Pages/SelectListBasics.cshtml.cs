using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SandBox.Pages
{
    public class SelectListBasicsModel : PageModel
    {
        [BindProperty]
        public int Number { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
        }
    }
}
