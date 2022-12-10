[ViewComponent]
public class HeadMain : ViewComponent
{
    private readonly IPageInfoRepository _pageInfoContext;
    public HeadMain(IPageInfoRepository pageInfoContext) => _pageInfoContext = pageInfoContext;

    public async Task<IViewComponentResult> InvokeAsync()
    {

        PageInfoModel pageInfoModel = await _pageInfoContext.PagesInfo.FirstAsync()!;

        return View(pageInfoModel);
    }
}