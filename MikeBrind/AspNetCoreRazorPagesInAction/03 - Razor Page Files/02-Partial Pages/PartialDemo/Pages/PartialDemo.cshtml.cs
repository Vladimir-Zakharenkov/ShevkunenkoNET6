using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PartialDemo.Pages
{
    public class PartialDemoModel : PageModel
    {
        public List<string> Animals = new List<string>();
        public void OnGet()
        {
            Animals.AddRange(new[] { "Antelope", "Badger", "Cat", "Dog" });
        }
    }
}
