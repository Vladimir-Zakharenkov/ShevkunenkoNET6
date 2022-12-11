[ViewComponent]
public class BackgroundFoto : ViewComponent
{
    private IBackgroundFotoRepository _backgroundFoto;
    public BackgroundFoto(IBackgroundFotoRepository backgroundFoto)
    {
        _backgroundFoto = backgroundFoto;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        BackgroundFileModel backgroundImage = await _backgroundFoto.GetBackgroundFotoByPathAsync(HttpContext.Request.Path.ToString().Trim('/'));

        return View(backgroundImage);
    }
}
