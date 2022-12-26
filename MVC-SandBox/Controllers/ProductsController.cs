using Microsoft.AspNetCore.Mvc;
using Microsoft.Docs.Samples;

namespace MVC_SandBox.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Details(int id)
        {
            return ControllerContext.MyDisplayRouteInfo(id);
        }
    }
}
