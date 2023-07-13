//using Microsoft.AspNetCore.Mvc;
//using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers;

public class HomeController : Controller
{
    public ViewResult Index()
    {
        //return View(new string[] { "C#","Language","Features"});
        //Product?[] products = Product.GetProducts();
        //return View(new string[] { products[0]?.Name ?? "No value" });//null-coalescing
        //return View(new string[] { products[0]!.Name });//null forgiving
        //return View(new string[] { $"Name: {products[0]?.Name}, Price:{products[0]?.Price:C2}"});//string interpolation
        //return View("Index", new string[] { "Bob", "Joe", "Alice" });//collection initializer
        //Dictionary<string, Product> products = new Dictionary<string, Product> //object initializer
        //{
        //    { "Kayak",new Product {Name="Kayak",Price=275M } },
        //    { "Lifejacket",new Product {Name="Lifejacket",Price=48.95M } }
        //};
        //return View("Index", products.Keys);
        //Dictionary<string, Product> products = new Dictionary<string, Product> //object initializer (more latest version)
        //{
        //    ["Kayak"] = new Product { Name = "Kayak", Price = 275M },
        //    ["Lifejacket"] = new Product { Name = "Lifejacket", Price = 48.95M }
        //};
        //return View("Index", products.Keys);
        Dictionary<string, Product> products = new() //target-typed new expressions
        {
            ["Kayak"] = new Product { Name = "Kayak", Price = 275M },
            ["Lifejacket"] = new Product { Name = "Lifejacket", Price = 48.95M }
        };
        return View("Index", products.Keys);
    }
}
