[ViewComponent]
public class BackgroundFoto : ViewComponent
{
    private SiteDbContext _siteContext;
    public BackgroundFoto(SiteDbContext siteContext)
    {
        _siteContext = siteContext;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var pagePath = HttpContext.Request.Path.ToString();

        if (pagePath == null || pagePath == "/")
        {
            pagePath = "/Index";
        }

        PageInfoModel? pageInfo = await _siteContext.PageInfo
            .Include(p => p.BackgroundFileModel)
            .FirstOrDefaultAsync(p => p.PageLoc == pagePath);

        if (pageInfo != null)
        {
            BackgroundFileModel? backgroundFile = await _siteContext.BackgroundFile
                .FirstOrDefaultAsync(p => p.BackgroundFileModelId == pageInfo.BackgroundFileModelId);

            return View(backgroundFile);
        }
        else
        {
            Guid indexPage = new("B457B4A0F8C04888E1F108DADAEED08C");

            BackgroundFileModel? backgroundFile = await _siteContext.BackgroundFile
                .FirstOrDefaultAsync(p => p.BackgroundFileModelId == indexPage);

            return View(backgroundFile);

        }
    }
}
