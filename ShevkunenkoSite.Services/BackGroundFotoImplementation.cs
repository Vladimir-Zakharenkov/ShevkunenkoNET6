using Microsoft.EntityFrameworkCore;
using ShevkunenkoSite.Models;

namespace ShevkunenkoSite.Services;

public class BackGroundFotoImplementation : IBackgroundFotoRepository
{
    private SiteDbContext _siteContext;
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

        var test = await _siteContext.PageInfo.Where(p => p.PageLoc == pagePath).AnyAsync();

        if (!test)
        {
            pagePath += "/Index";
        }

        PageInfoModel? pageInfo = await _siteContext.PageInfo
           .Include(p => p.BackgroundFileModel)
           .FirstOrDefaultAsync(p => p.PageLoc == pagePath);

        if (pageInfo != null)
        {
            BackgroundFileModel? backgroundFile = await _siteContext.BackgroundFile
                .FirstOrDefaultAsync(p => p.BackgroundFileModelId == pageInfo.BackgroundFileModelId);

            return backgroundFile;
        }
        else
        {
            Guid indexPage = new("B40676297CC94D79A0C208DADB48DCD9");

            BackgroundFileModel? backgroundFile = await _siteContext.BackgroundFile
                .FirstOrDefaultAsync(p => p.BackgroundFileModelId == indexPage);

            return backgroundFile;

        }
    }
}
