public class Head : ViewComponent
{
    private readonly IPageInfoRepository _pageInfoContext;
    public Head(IPageInfoRepository pageInfoContext) => _pageInfoContext = pageInfoContext;

    public async Task<IViewComponentResult> InvokeAsync()
    {
        PageInfoModel pageInfoModel = await _pageInfoContext.PagesInfo.FirstAsync()!;

        return View(pageInfoModel);
    }
}
