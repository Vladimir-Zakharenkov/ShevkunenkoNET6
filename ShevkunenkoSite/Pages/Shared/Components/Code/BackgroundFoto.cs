namespace ShevkunenkoSite.Pages.Shared.Components.Code;

[ViewComponent]
public class BackgroundFoto : ViewComponent
{
    private readonly IPageInfoRepository _pageInfoContext;
    public BackgroundFoto(IPageInfoRepository pageInfoContext) => _pageInfoContext = pageInfoContext;

    public async Task<IViewComponentResult> InvokeAsync(bool left)
    {
        PageInfoModel pageInfoModel = await _pageInfoContext.GetPageInfoByPathAsync(HttpContext.Request.Path.ToString()[1..].ToLower().Trim('/'));

        return left
            ? View("BackgroundFoto", pageInfoModel.BackgroundFileModel.LeftBackground)
            : (IViewComponentResult)View("BackgroundFoto", pageInfoModel.BackgroundFileModel.RightBackground);
    }
}