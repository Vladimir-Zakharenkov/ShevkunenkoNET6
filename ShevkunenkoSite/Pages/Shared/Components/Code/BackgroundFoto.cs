[ViewComponent]
public class BackgroundFoto : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        string testString = "Fotoplenka.png";

        return View(testString);
    }
}
