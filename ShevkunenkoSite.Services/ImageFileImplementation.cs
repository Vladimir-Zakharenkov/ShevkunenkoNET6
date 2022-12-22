namespace ShevkunenkoSite.Services;

public class ImageFileImplementation : IImageFileRepository
{
    private readonly SiteDbContext _siteContext;
    public ImageFileImplementation(SiteDbContext siteContext) => _siteContext = siteContext;

    public IQueryable<ImageFileModel> ImageFiles => _siteContext.ImageFile;
}
