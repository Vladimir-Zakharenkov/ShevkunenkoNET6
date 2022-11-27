//using LanguageFeatures.Models;
//using Microsoft.AspNetCore.Mvc;

namespace LanguageFeatures.Controllers;

public class HomeController : Controller
{
    public ViewResult Index()
    {
        Product?[] products = Product.GetProducts();

        #region Example1

        //Product? p = products[0];

        //string val;

        //if (p != null)
        //{
        //    val = p.Name;
        //}
        //else
        //{
        //    val = "No value";
        //}
        //return View(new string[] { val });

        #endregion

        #region Example2

        //string? val = products[0]?.Name;

        //if (val != null)
        //{
        //    return View(new string[] { val });
        //}
        //return View(new string[] { "No Value" });

        #endregion

        #region Example3

        //return View(new string[] { products[0]?.Name ?? "No Value" });

        #endregion

        #region Example4

        return View(new string[] { products[0]!.Name });

        #endregion
    }
}
