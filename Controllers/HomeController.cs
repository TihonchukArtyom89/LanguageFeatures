//using Microsoft.AspNetCore.Mvc;
//using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers;

public class HomeController : Controller
{
    public ViewResult Index()
    {
        //return View(new string[] { "C#","Language","Features"});
        Product?[] products = Product.GetProducts();
        Product? p = products[0];
        string val;
        if (p != null)
        {
            val = p.Name;
        }
        else
        {
            val = "No value";
        }
        return View(new string[] { val });
    }
}
