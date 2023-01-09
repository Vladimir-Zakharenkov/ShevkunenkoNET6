using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SandBox.Pages
{
    public class OptionGroupsModel : PageModel
    {
        public int Employee { get; set; }
        public List<SelectListItem> Staff { get; set; } = null!;

        public void OnGet()
        {
            var Sales = new SelectListGroup { Name = "Sales" };
            var Admin = new SelectListGroup { Name = "Admin" };
            var IT = new SelectListGroup { Name = "IT" };
            Staff = new List<SelectListItem>
            {
                new SelectListItem{ Value = "1", Text = "Mike", Group = IT},
                new SelectListItem{ Value = "2", Text = "Pete", Group = Sales},
                new SelectListItem{ Value = "3", Text = "Katy", Group = Admin},
                new SelectListItem{ Value = "4", Text = "Dean", Group = Sales}
            };
        }
    }
}
