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

        //Dictionary<string, Product> products2 = new Dictionary<string, Product>
        //{
        //    ["Kayak"] = new Product { Name = "Kayak", Price = 275M },
        //    ["Lifejacket"] = new Product { Name = "Lifejacket", Price = 48.95M }
        //};
        //return View("Index", products2.Keys);

        #endregion

        #region Example10

        //Dictionary<string, Product> products2 = new()
        //{
        //    ["Kayak"] = new Product { Name = "Kayak", Price = 275M },
        //    ["Lifejacket"] = new Product { Name = "Lifejacket", Price = 48.95M }
        //};
        //return View("Index", products2.Keys);

        #endregion

        #region Example11

        //object[] data = new object[] { 275M, 29.95M, "apple", "orange", 100, 10 };

        //decimal total = 0;

        //for (int i = 0; i < data.Length; i++)
        //{
        //    if (data[i] is decimal d)
        //    {
        //        total += d;
        //    }
        //}

        //return View("Index", new string[] { $"Total: {total:C2}" });

        #endregion

        #region Example12

        //object[] data = new object[] { 275M, 29.95M, "apple", "orange", 100, 10 };

        //decimal total = 0;

        //for (int i = 0; i < data.Length; i++)
        //{
        //    switch (data[i])
        //    {
        //        case decimal decimalValue:
        //            total += decimalValue;
        //            break;
        //        case int intValue when intValue > 50:
        //            total += intValue;
        //            break;
        //    }
        //}

        //return View("Index", new string[] { $"Total: {total:C2}" });

        #endregion

        #region Example13

        //ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };

        //decimal cartTotal = cart.TotalPrices();

        //return View("Index", new string[] { $"Total: {cartTotal:C2}" });

        #endregion

        #region Example14

        //ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };

        //Product[] productArray = {
        //        new Product {Name = "Kayak", Price = 275M},
        //        new Product {Name = "Lifejacket", Price = 48.95M}
        //    };

        //decimal cartTotal = cart.TotalPrices();

        //decimal arrayTotal = productArray.TotalPrices();

        //return View("Index", new string[] {
        //    $"Cart Total: {cartTotal:C2}",
        //    $"Array Total: {arrayTotal:C2}" });

        #endregion

        #region Example15

        ////ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };

        //Product[] productArray = {
        //    new Product {Name = "Kayak", Price = 275M},
        //    new Product {Name = "Lifejacket", Price = 48.95M},
        //    new Product {Name = "Soccer ball", Price = 19.50M},
        //    new Product {Name = "Corner flag", Price = 34.95M}
        //    };

        //decimal arrayTotal = productArray.FilterByPrice(20).TotalPrices();

        //return View("Index", new string[] { $"Array Total: {arrayTotal:C2}" });

        #endregion

        #region Example16

        //ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };

        Product[] productArray = {
                new Product {Name = "Kayak", Price = 275M},
                new Product {Name = "Lifejacket", Price = 48.95M},
                new Product {Name = "Soccer ball", Price = 19.50M},
                new Product {Name = "Corner flag", Price = 34.95M}
            };

        decimal priceFilterTotal = productArray.FilterByPrice(20).TotalPrices();
        decimal nameFilterTotal = productArray.FilterByName('S').TotalPrices();

        return View("Index", new string[] {
                $"Price Total: {priceFilterTotal:C2}",
                $"Name Total: {nameFilterTotal:C2}" });


        #endregion
    }
}
