using ShevkunenkoSite.Services;

public class SiteServicesImplementation : ISiteServices
{
    private IPageInfoRepository _pageContext;
    public SiteServicesImplementation(IPageInfoRepository pageContext)
    {
        _pageContext = pageContext;
    }

    public string GetPagePath(string? pagePath)
    {
        if (pagePath == null || pagePath == String.Empty)
        {
            pagePath = "Index";
        }

        if (_pageContext.PagesInfo.Where(p => p.PageLoc == pagePath) == null)
        {
            pagePath += "/Index";
        }

        return pagePath;
    }
}
