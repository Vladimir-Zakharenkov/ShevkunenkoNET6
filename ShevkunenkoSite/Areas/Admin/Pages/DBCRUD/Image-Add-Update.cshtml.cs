using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ShevkunenkoSite.Areas.Admin.Pages.DBCRUD;

[BindProperties]
public class Image_Add_UpdateModel : PageModel
{
    private readonly IImageFileRepository _imageContext;
    public Image_Add_UpdateModel(IImageFileRepository imageContext) => _imageContext = imageContext;

    public ImageFileModel ImageItem { get; set; } = null!;

    public string[] AllDirInImages = Directory.GetDirectories(Directory.GetCurrentDirectory() + "\\wwwroot\\images");

    public List<SelectListItem> ImageDirectories { get; set; } =
        Directory.GetDirectories(Directory.GetCurrentDirectory() + "\\wwwroot\\images")
        .Select(a => new SelectListItem
        {
            Value = a[(Directory.GetDirectories(Directory.GetCurrentDirectory() + "\\wwwroot\\images")[0].IndexOf("images") + 7)..],
            Text = a[(Directory.GetDirectories(Directory.GetCurrentDirectory() + "\\wwwroot\\images")[0].IndexOf("images") + 7)..]
        })
        .ToList();

    public string SelectedTag { get; set; } = string.Empty;

    //[Display(Name = "Новый каталог :")]
    //public string NewImagePath { get; set; } = string.Empty;



    //public IFormFile ImageFormFile { get; set; } = null!;

    //public IFormFile IconFormFile { get; set; } = null!;

    //public string[] AllDirInImagesFolder = Directory.GetDirectories(Directory.GetCurrentDirectory() + "\\wwwroot\\images");


    public async Task<IActionResult> OnGetAsync(Guid? imageId)
    {
        if (imageId.HasValue)
        {
            ImageItem = await _imageContext.ImageFiles.FirstAsync(i => i.ImageFileModelId == imageId);

            if (ImageItem == null)
            {
                return RedirectToPage("/DBCRUD/Image-List", new { area = "Admin" });
            }

            SelectedTag = ImageItem.ImagePath[7..];

            return Page();
        }
        else
        {
            ImageItem = new();

            return Page();
        }
    }
}