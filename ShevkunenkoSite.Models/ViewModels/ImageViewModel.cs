namespace ShevkunenkoSite.Models.ViewModels;

public class ImageViewModel
{
    public ImageFileModel? ImageItem { get; set; } = null!;

    public string? CssClass { get; set; }

    public bool? IsIcon { get; set; }
}
