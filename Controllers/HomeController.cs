//using Microsoft.AspNetCore.Mvc;
//using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers;

public class HomeController : Controller
{
    public ViewResult Index()
    {
        //return View(new string[] { "C#","Language","Features"});
        Product?[] products = Product.GetProducts();
        //return View(new string[] { products[0]?.Name ?? "No value" });//null-coalescing
        return View(new string[] { products[0]!.Name });//null forgiving
    }
}
