#region Example1

//using Microsoft.AspNetCore.Mvc;

//namespace SportsStore.Components
//{
//    public class NavigationMenuViewComponent : ViewComponent
//    {
//        public string Invoke()
//        {
//            return "Hello from the Nav View Component";
//        }
//    }
//}

#endregion

#region Example2

//using Microsoft.AspNetCore.Mvc;
//using SportsStore.Models;

//namespace SportsStore.Components
//{
//    public class NavigationMenuViewComponent : ViewComponent
//    {
//        private IStoreRepository repository;

//        public NavigationMenuViewComponent(IStoreRepository repo)
//        {
//            repository = repo;
//        }

//        public IViewComponentResult Invoke()
//        {
//            return View(repository.Products
//                .Select(x => x.Category)
//                .Distinct()
//                .OrderBy(x => x));
//        }
//    }
//}

#endregion

#region Example3

using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;

namespace SportsStore.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IStoreRepository repository;
        public NavigationMenuViewComponent(IStoreRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(repository.Products
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}

#endregion