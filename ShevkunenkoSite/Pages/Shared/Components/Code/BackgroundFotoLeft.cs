[ViewComponent]
public class BackgroundFotoLeft : ViewComponent
{
    private readonly IBackgroundFotoRepository _backgroundFoto;
    public BackgroundFotoLeft(IBackgroundFotoRepository backgroundFoto)
    {
        _backgroundFoto = backgroundFoto;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        BackgroundFileModel backgroundImage = await _backgroundFoto.GetBackgroundFotoByPathAsync(HttpContext.Request.Path.ToString().Trim('/'));

        return View(backgroundImage);
    }
}
