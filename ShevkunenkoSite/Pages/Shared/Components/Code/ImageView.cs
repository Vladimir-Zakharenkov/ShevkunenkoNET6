namespace ShevkunenkoSite.Pages.Shared.Components.Code;

[ViewComponent]
public class ImageView : ViewComponent
{
    private readonly IImageFileRepository _imageFileContext;
    public ImageView(IImageFileRepository imageFileContext) => _imageFileContext = imageFileContext;

    public async Task<IViewComponentResult> InvokeAsync(string fileName, string cssClass, bool isIcon)
    {
        ImageFileModel? imageItem = await _imageFileContext.ImageFiles.FirstOrDefaultAsync(img => img.ImageFileName == fileName);

        if (imageItem == null)
        {
            imageItem = await _imageFileContext.ImageFiles.FirstOrDefaultAsync(img => img.ImageFileName == "no-image.png");
        }

        return View(new ImageViewModel
        {
            ImageItem = imageItem,
            CssClass = cssClass,
            IsIcon = isIcon
        });
    }
}
