using ShevkunenkoSite.Models;

namespace ShevkunenkoSite.Services;

public class PageInfoImplementation : IPageInfoRepository
{
    private SiteDbContext _siteContext;
    public PageInfoImplementation(SiteDbContext siteContext)
    {
        _siteContext = siteContext;
    }
    public IQueryable<PageInfoModel> PagesInfo => _siteContext.PageInfo;
}
