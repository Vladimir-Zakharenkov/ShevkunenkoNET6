namespace ShevkunenkoSite.Pages.Shared.Components.Code;

[ViewComponent]
public class HeadMain : ViewComponent
{
    private readonly IPageInfoRepository _pageInfoContext;
    private readonly IIconFileRepository _iconFileContext;
    public HeadMain(IPageInfoRepository pageInfoContext, IIconFileRepository iconFileContext)
    {
        _pageInfoContext = pageInfoContext;
        _iconFileContext = iconFileContext;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        PageInfoModel pageInfoModel = await _pageInfoContext.GetPageInfoByPathAsync(HttpContext.Request.Path.ToString()[1..].ToLower().Trim('/'));

        List<IconFileModel> iconList = await _iconFileContext.IconFiles.Where(icon => icon.IconPath == pageInfoModel.IconPath).ToListAsync();

        return View(new HeadViewModel
        {
            PageInfo = pageInfoModel,

            IconList = iconList
        });
    }
}