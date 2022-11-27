using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFeatures.Controllers;

public class HomeController : Controller
{
	public ViewResult Index()
	{
        //return View(new string[] { "C#", "Language", "Features" });

        Product[] products = Product.GetProducts();
        return View(new string[] { products[0].Name });

    }
}
