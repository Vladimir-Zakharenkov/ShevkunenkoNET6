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

        //return View(new string[] { products[0]!.Name });

        #endregion

        #region Example5

        //return View(new string[] {
        //    $"Name: {products[0]?.Name}, Price: { products[0]?.Price }"
        //    });

        #endregion

        #region Example6

        //string[] names = new string[3];
        //names[0] = "Bob";
        //names[1] = "Joe";
        //names[2] = "Alice";
        //return View("Index", names);

        #endregion

        #region Example7

        //return View("Index", new string[] { "Bob", "Joe", "Alice" });

        #endregion

        #region Example8

        //Dictionary<string, Product> products2 = new Dictionary<string, Product> {
        //        { "Kayak", new Product { Name = "Kayak", Price = 275M } },
        //        { "Lifejacket", new Product{ Name = "Lifejacket", Price = 48.95M } }
        //    };

        //return View("Index", products2.Keys);

        #endregion

        #region Example9

        Dictionary<string, Product> products2 = new Dictionary<string, Product>
        {
            ["Kayak"] = new Product { Name = "Kayak", Price = 275M },
            ["Lifejacket"] = new Product { Name = "Lifejacket", Price = 48.95M }
        };
        return View("Index", products2.Keys);

        #endregion
    }
}
