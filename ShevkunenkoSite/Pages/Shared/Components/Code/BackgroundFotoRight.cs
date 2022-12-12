[ViewComponent]
public class BackgroundFotoRight : ViewComponent
{
    private readonly IBackgroundFotoRepository _backgroundFoto;
    public BackgroundFotoRight(IBackgroundFotoRepository backgroundFoto)
    {
        _backgroundFoto = backgroundFoto;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        BackgroundFileModel backgroundImage = await _backgroundFoto.GetBackgroundFotoByPathAsync(HttpContext.Request.Path.ToString().Trim('/'));

        return View(backgroundImage);
    }
}
