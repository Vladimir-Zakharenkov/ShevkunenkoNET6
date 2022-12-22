namespace ShevkunenkoSite.Services;

public class IconFileImplementation : IIconFileRepository
{
    private readonly SiteDbContext _siteContext;
    public IconFileImplementation(SiteDbContext siteContext) => _siteContext = siteContext;

    public IQueryable<IconFileModel> IconFiles => _siteContext.IconFile;
}
