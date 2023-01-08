using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SandBox.Pages
{
    public class UsingEnumerationModel : PageModel
    {
        public DayOfWeek DayOfWeek { get; set; }

        public void OnGet()
        {
        }
    }
}
