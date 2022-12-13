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

    public async Task<PageInfoModel> GetPageInfoByPathAsync(string? pagePath)
    {
        if (pagePath == null || pagePath == String.Empty)
        {
            pagePath = "Index";
        }

        bool isPageInDatabase = await _siteContext.PageInfo
            .Where(p => p.PageLoc == pagePath)
            .AnyAsync();

        if (!isPageInDatabase)
        {
            pagePath += "/Index";
        }

        isPageInDatabase = await _siteContext.PageInfo
            .Where(p => p.PageLoc == pagePath)
            .AnyAsync();

        if (isPageInDatabase)
        {
            PageInfoModel pageItem = await _siteContext.PageInfo
                .FirstAsync(p => p.PageLoc == pagePath);

            return pageItem;
        }
        else
        {
            PageInfoModel pageItem = await _siteContext.PageInfo
                .FirstAsync(p => p.PageLoc == "Index");

            return pageItem;
        }
    }
}
