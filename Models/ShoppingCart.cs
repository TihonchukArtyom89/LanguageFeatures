using System.Collections;
namespace LanguageFeatures.Models;

public class ShoppingCart: IEnumerable<Product?> //base class 
{
    public IEnumerable<Product?>? Products { get; set; }
    public IEnumerator<Product?> GetEnumerator() =>Products?.GetEnumerator()??Enumerable.Empty<Product?>().GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
