namespace LanguageFeatures.Models;

using System.Collections;

#region Example1
//public class ShoppingCart
//{
//    public IEnumerable<Product?>? Products { get; set; }
//}

#endregion

#region Example2

public class ShoppingCart : IEnumerable<Product?>
{
    public IEnumerable<Product?>? Products { get; set; }

    public IEnumerator<Product?> GetEnumerator() => Products?.GetEnumerator()
        ?? Enumerable.Empty<Product?>().GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

#endregion
