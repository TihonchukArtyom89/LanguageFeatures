namespace LanguageFeatures.Models;

public static class MyExtensionMethod//class of extension method (extension ShoppingCart class)
{
    public static decimal TotalPrices(this IEnumerable<Product?> products)
    {
        decimal total = 0;
        //if (cartParam.Products != null)//extension of simple class
        //{
        //    foreach (Product? prod in cartParam.Products)
        //    {
        //        total += prod?.Price ?? 0;
        //    }
        //}
        foreach (Product? prod in products)//extension method of interface
        {
            total += prod?.Price ?? 0;
        }
        return total;
    }
    public static IEnumerable<Product?> FilterByPrice(this IEnumerable<Product?> productEnum, decimal minimumPrice)
    {
        foreach (Product? prod in productEnum)
        {
            if ((prod?.Price ?? 0) >=minimumPrice)
            {
                yield return prod;
            }
        }
    }
}
