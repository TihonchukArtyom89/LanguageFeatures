//using Microsoft.AspNetCore.Mvc;
//using LanguageFeatures.Models;

using LanguageFeatures.Models;
using System.Xml.Linq;

namespace LanguageFeatures.Controllers;

public class HomeController : Controller
{
    //bool FilterByPrice(Product? p)
    //{
    //    return (p?.Price ?? 0) >= 20;
    //}
    //public ViewResult Index()
    //{
    //    //return View(new string[] { "C#","Language","Features"});
    //    //Product?[] products = Product.GetProducts();
    //    //return View(new string[] { products[0]?.Name ?? "No value" });//null-coalescing
    //    //return View(new string[] { products[0]!.Name });//null forgiving
    //    //return View(new string[] { $"Name: {products[0]?.Name}, Price:{products[0]?.Price:C2}"});//string interpolation
    //    //return View("Index", new string[] { "Bob", "Joe", "Alice" });//collection initializer
    //    //Dictionary<string, Product> products = new Dictionary<string, Product> //object initializer
    //    //{
    //    //    { "Kayak",new Product {Name="Kayak",Price=275M } },
    //    //    { "Lifejacket",new Product {Name="Lifejacket",Price=48.95M } }
    //    //};
    //    //return View("Index", products.Keys);
    //    //Dictionary<string, Product> products = new Dictionary<string, Product> //object initializer (more latest version)
    //    //{
    //    //    ["Kayak"] = new Product { Name = "Kayak", Price = 275M },
    //    //    ["Lifejacket"] = new Product { Name = "Lifejacket", Price = 48.95M }
    //    //};
    //    //return View("Index", products.Keys);
    //    //Dictionary<string, Product> products = new() //target-typed new expressions
    //    //{
    //    //    ["Kayak"] = new Product { Name = "Kayak", Price = 275M },
    //    //    ["Lifejacket"] = new Product { Name = "Lifejacket", Price = 48.95M }
    //    //};
    //    //return View("Index", products.Keys);
    //    //object[] data =new object[] { 275M,29.95M,"apple","orange",100,10};
    //    //decimal total = 0;
    //    //for(int i = 0; i < data.Length; i++)
    //    //{
    //    //    if (data[i] is decimal d)//pattern matching if
    //    //    {
    //    //        total += d;
    //    //    }
    //    //}
    //    //return View("Index",new string[] { $"Total: {total:C2}"});
    //    //object[] data = new object[] { 275M, 29.95M, "apple", "orange", 100, 10 };
    //    //decimal total = 0;
    //    //for (int i = 0; i < data.Length; i++)
    //    //{
    //    //    switch (data[i])//pattern matching switch
    //    //    {
    //    //        case decimal decimalValue:
    //    //            total += decimalValue; break;
    //    //        case int intValue when intValue > 50:
    //    //            total += intValue; break;
    //    //    }
    //    //}
    //    //return View("Index", new string[] { $"Total: {total:C2}" });
    //    //ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };
    //    //decimal cartTotal = cart.TotalPrices();//use extesion method on class
    //    //return View("Index",new string[] { $"Total:{cartTotal:C2}"});
    //    //Product[] productArray =  {
    //    //    new Product{Name="Kayak",Price=275M},
    //    //    new Product{Name="Lifejacket",Price=48.95M}
    //    //};
    //    //decimal cartTotal = cart.TotalPrices();//use extension method on interface
    //    //decimal arrayTotal = productArray.TotalPrices();
    //    //return View("Index",new string[]
    //    //{
    //    //    $"Cart Total: {cartTotal:C2}",
    //    //    $"Array Total: {arrayTotal:C2}"
    //    //});
    //    //Product[] productArray =  {
    //    //    new Product{Name="Kayak",Price=275M},
    //    //    new Product{Name="Lifejacket",Price=48.95M},
    //    //    new Product{Name="Soccer ball",Price=19.50M},
    //    //    new Product{Name="Corner flag",Price=34.95M}
    //    //};
    //    //decimal priceFilterTotal = productArray.FilterByPrice(20).TotalPrices();//use extension method filter(by price)
    //    //decimal nameFilterTotal = productArray.FilterByName('S').TotalPrices();//use extension method filter(be first character in name)
    //    //Func<Product?, bool> nameFilter = delegate (Product? prod)
    //    //{
    //    //    return prod?.Name?[0] == 'S';
    //    //};
    //    //decimal priceFilterTotal = productArray.Filter(FilterByPrice).TotalPrices();//filter by selector(another function)
    //    //decimal nameFilterTotal = productArray.Filter(nameFilter).TotalPrices();//filter by selector(delegate)
    //    //decimal priceFilterTotal = productArray.Filter(p=>(p?.Price ?? 0)>=20).TotalPrices();//use lambda expression
    //    //decimal nameFilterTotal = productArray.Filter(p => p?.Name[0] == 'S').TotalPrices();//use lambda expression
    //    //return View("Index", new string[]
    //    //{
    //    //    $"Price Total: {priceFilterTotal:C2}",
    //    //    $"Name Total: {nameFilterTotal:C2}"
    //    //});
    //    return View(Product.GetProducts().Select(p=>p?.Name));//rewritten return with lambda expression
    //}
    //public ViewResult Index()=> View(Product.GetProducts().Select(p=>p?.Name));//rewritten index action method with lambda expression in one line
    public ViewResult Index()
    {
        //var names = new[] { "Kayak", "Lifejacket", "Soccer ball" };//using type interference
        //var products= new[] {//using anonymous type
        //    new {Name="Kayak",Price=275M},
        //    new {Name="Lifejacket",Price=48.95M},
        //    new {Name="Soccer ball",Price=19.50M},
        //    new {Name="Corner flag",Price=34.95M}
        //};
        //return View(products.Select(p => p.GetType().Name));
        IProductSelection cart = new ShoppingCart (//using default implementations in interface
            new Product {Name="Kayak",Price=275M},
            new Product {Name="Lifejacket",Price=48.95M},
            new Product {Name="Soccer ball",Price=19.50M},
            new Product {Name="Corner flag",Price=34.95M}
        );
        return View(cart.Names);
    }
}
