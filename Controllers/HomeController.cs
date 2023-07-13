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
        //Dictionary<string, Product> products = new() //target-typed new expressions
        //{
        //    ["Kayak"] = new Product { Name = "Kayak", Price = 275M },
        //    ["Lifejacket"] = new Product { Name = "Lifejacket", Price = 48.95M }
        //};
        //return View("Index", products.Keys);
        //object[] data =new object[] { 275M,29.95M,"apple","orange",100,10};
        //decimal total = 0;
        //for(int i = 0; i < data.Length; i++)
        //{
        //    if (data[i] is decimal d)//pattern matching if
        //    {
        //        total += d;
        //    }
        //}
        //return View("Index",new string[] { $"Total: {total:C2}"});
        //object[] data = new object[] { 275M, 29.95M, "apple", "orange", 100, 10 };
        //decimal total = 0;
        //for (int i = 0; i < data.Length; i++)
        //{
        //    switch (data[i])//pattern matching switch
        //    {
        //        case decimal decimalValue:
        //            total += decimalValue; break;
        //        case int intValue when intValue > 50:
        //            total += intValue; break;
        //    }
        //}
        //return View("Index", new string[] { $"Total: {total:C2}" });
        ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };
        //decimal cartTotal = cart.TotalPrices();//use extesion method on class
        //return View("Index",new string[] { $"Total:{cartTotal:C2}"});
        //Product[] productArray =  {
        //    new Product{Name="Kayak",Price=275M},
        //    new Product{Name="Lifejacket",Price=48.95M}
        //};
        //decimal cartTotal = cart.TotalPrices();//use extension method on interface
        //decimal arrayTotal = productArray.TotalPrices();
        //return View("Index",new string[]
        //{
        //    $"Cart Total: {cartTotal:C2}",
        //    $"Array Total: {arrayTotal:C2}"
        //});
        Product[] productArray =  {
            new Product{Name="Kayak",Price=275M},
            new Product{Name="Lifejacket",Price=48.95M},
            new Product{Name="Soccer ball",Price=19.50M},
            new Product{Name="Corner flag",Price=34.95M}
        };
        decimal arrayTotal = productArray.FilterByPrice(20).TotalPrices();//use extension method filtr
        return View("Index", new string[]
        {
            $"Array Total: {arrayTotal:C2}"
        });
    }
}
