namespace ShevkunenkoSite.Areas.Admin.Pages.DBCRUD;

public class Image_ListModel : PageModel
{
    private readonly IImageFileRepository _imageContext;
    public Image_ListModel(IImageFileRepository imageContext) => _imageContext = imageContext;

    public IList<ImageFileModel> AllImages { get; set; } = new List<ImageFileModel>();

    public async Task OnGetAsync()
    {
        AllImages = await _imageContext.ImageFiles.ToListAsync();
    }
}