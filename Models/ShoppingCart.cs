using System.Collections;
namespace LanguageFeatures.Models;

public class ShoppingCart /*: IEnumerable<Product?>*/ : IProductSelection //base class 
{
    private List<Product> products = new();
    public ShoppingCart(params Product[] prods)
    {
        products.AddRange(prods);
    }
    public IEnumerable<Product>? Products { get => products; }
    //public IEnumerator<Product?> GetEnumerator() => Products?.GetEnumerator() ?? Enumerable.Empty<Product?>().GetEnumerator();
    //IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
