using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SandBox.Pages
{
    public enum Rating
    {
        Unrated,
        [Display(Name = "1 Star")]
        OneStar,
        [Display(Name = "2 Star")]
        TwoStar,
        [Display(Name = "3 Star")]
        ThreeStar,
        [Display(Name = "4 Star")]
        FourStar,
        [Display(Name = "5 Star")]
        FiveStar
    }

    public class OwnEnumerationModel : PageModel
    {
        [BindProperty]
        public Rating Rate { get; set; }

        public void OnGet()
        {
        }
    }
}
