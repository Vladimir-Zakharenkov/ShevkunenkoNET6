using Microsoft.AspNetCore.Mvc.Rendering;

namespace ShevkunenkoSite.Areas.Admin.Pages.DBCRUD;

[BindProperties]
public class Image_Add_UpdateModel : PageModel
{
    private readonly IImageFileRepository _imageContext;
    public Image_Add_UpdateModel(IImageFileRepository imageContext) => _imageContext = imageContext;

    public ImageFileModel? ImageItem { get; set; }

    [Display(Name = "Новый каталог :")]
    public string NewImagePath { get; set; } = string.Empty;

    public IFormFile ImageFormFile { get; set; } = null!;

    public IFormFile IconFormFile { get; set; } = null!;

    public string[] AllDirInImagesFolder = Directory.GetDirectories(Directory.GetCurrentDirectory() + "\\wwwroot\\images");

    public List<SelectListItem> Options { get; set; } = null!;

    public async Task<IActionResult> OnGetAsync(Guid? imageId)
    {
    }
}