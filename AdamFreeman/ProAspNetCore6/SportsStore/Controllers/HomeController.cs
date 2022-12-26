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

//using Microsoft.AspNetCore.Mvc;
//using SportsStore.Models;

//public class HomeController : Controller
//{
//    private IStoreRepository repository;
//    public HomeController(IStoreRepository repo)
//    {
//        repository = repo;
//    }

//    public IActionResult Index() => View(repository.Products);
//}

#endregion

#region Example3

//using Microsoft.AspNetCore.Mvc;
//using SportsStore.Models;

//public class HomeController : Controller
//{
//    private IStoreRepository repository;
//    public HomeController(IStoreRepository repo)
//    {
//        repository = repo;
//    }

//    public int PageSize = 4;

//    public ViewResult Index(int productPage = 1)
//            => View(repository.Products
//                .OrderBy(p => p.ProductID)
//                .Skip((productPage - 1) * PageSize)
//                .Take(PageSize));
//}

#endregion

#region Example4

//using Microsoft.AspNetCore.Mvc;
//using SportsStore.Models;
//using SportsStore.Models.ViewModels;

//namespace SportsStore.Controllers
//{
//    public class HomeController : Controller
//    {
//        private IStoreRepository repository;
//        public int PageSize = 4;
//        public HomeController(IStoreRepository repo)
//        {
//            repository = repo;
//        }

//        public ViewResult Index(int productPage = 1)
//            => View(new ProductsListViewModel
//            {
//                Products = repository.Products
//                    .OrderBy(p => p.ProductID)
//                    .Skip((productPage - 1) * PageSize)
//                    .Take(PageSize),
//                PagingInfo = new PagingInfo
//                {
//                    CurrentPage = productPage,
//                    ItemsPerPage = PageSize,
//                    TotalItems = repository.Products.Count()
//                }
//            });
//    }
//}

#endregion

#region Example5

//using Microsoft.AspNetCore.Mvc;
//using SportsStore.Models;
//using SportsStore.Models.ViewModels;

//namespace SportsStore.Controllers
//{
//    public class HomeController : Controller
//    {
//        private IStoreRepository repository;
//        public int PageSize = 4;
//        public HomeController(IStoreRepository repo)
//        {
//            repository = repo;
//        }

//        public ViewResult Index(string? category, int productPage = 1)
//            => View(new ProductsListViewModel
//            {
//                Products = repository.Products
//                    .Where(p => category == null || p.Category == category)
//                    .OrderBy(p => p.ProductID)
//                    .Skip((productPage - 1) * PageSize)
//                    .Take(PageSize),

//                PagingInfo = new PagingInfo
//                {
//                    CurrentPage = productPage,
//                    ItemsPerPage = PageSize,
//                    TotalItems = repository.Products.Count()
//                },

//                CurrentCategory = category
//            });
//    }
//}

#endregion

#region Listing 8-12

using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using SportsStore.Models.ViewModels;

namespace SportsStore.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;
        public int PageSize = 4;
        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index(string? category, int productPage = 1)
            => View(new ProductsListViewModel
        {
                Products = repository.Products
                    .Where(p => category == null || p.Category == category)
                    .OrderBy(p => p.ProductID)
                    .Skip((productPage - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null
                        ? repository.Products.Count()
                        : repository.Products.Where(e =>
                            e.Category == category).Count()
                },
                CurrentCategory = category
        });
    }
}

#endregion