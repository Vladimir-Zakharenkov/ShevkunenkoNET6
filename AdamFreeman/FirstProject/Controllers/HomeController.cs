using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstProject.Models;

namespace FirstProject.Controllers;

public class HomeController : Controller
{
    #region DefaultEdition

    //private readonly ILogger<HomeController> _logger;

    //public HomeController(ILogger<HomeController> logger)
    //{
    //    _logger = logger;
    //}

    //public IActionResult Index()
    //{
    //    return View();
    //}

    //public IActionResult Privacy()
    //{
    //    return View();
    //}

    //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    //public IActionResult Error()
    //{
    //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    //}

    #endregion

    #region ReturnString

    //public string Index()
    //{
    //    return "Hello World";
    //}

    #endregion

    #region ReturnViewResult

    //public ViewResult Index()
    //{
    //    return View("MyView");
    //}

    #endregion

    #region DynamicReturn

    public ViewResult Index()
    {
        int hour = DateTime.Now.Hour;

        string viewModel = hour < 12 ? "Good Morning" : "Good Afternoon";

        return View("MyView", viewModel);
    }

    #endregion

}
