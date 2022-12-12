public class BackGroundFotoImplementation : IBackgroundFotoRepository
{
    private readonly SiteDbContext _siteContext;
    public BackGroundFotoImplementation(SiteDbContext siteContext)
    {
        _siteContext = siteContext;
    }

    public IQueryable<BackgroundFileModel> BackgroundFiles => _siteContext.BackgroundFile;

    public async Task<BackgroundFileModel> GetBackgroundFotoByPathAsync(string? pagePath)
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

            BackgroundFileModel backgroundFile = await _siteContext.BackgroundFile
                .FirstAsync(p => p.BackgroundFileModelId == pageItem.BackgroundFileModelId);

            return backgroundFile;
        }
        else
        {
            BackgroundFileModel backgroundFile = await _siteContext.BackgroundFile
                .FirstAsync(p => p.LeftBackground == "FotoPlenka.png");

            return backgroundFile;
        }
    }
}
