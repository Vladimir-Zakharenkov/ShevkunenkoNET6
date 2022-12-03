#region Example1

//using Microsoft.AspNetCore.Mvc;

//namespace SportsStore.Controllers
//{
//    public class HomeController : Controller
//    {
//        public IActionResult Index() => View();
//    }
//}

#endregion

#region Example2

using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

public class HomeController : Controller
{
    private IStoreRepository repository;
    public HomeController(IStoreRepository repo)
    {
        repository = repo;
    }

    public IActionResult Index() => View(repository.Products);
}

#endregion