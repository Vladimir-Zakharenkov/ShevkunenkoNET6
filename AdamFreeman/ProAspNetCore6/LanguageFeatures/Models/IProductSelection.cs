namespace LanguageFeatures.Models;

#region Examle1
//public interface IProductSelection
//{
//    IEnumerable<Product>? Products { get; }
//}
#endregion

#region Examle2
public interface IProductSelection
{
    IEnumerable<Product>? Products { get; }

    IEnumerable<string>? Names => Products?.Select(p => p.Name);
}
#endregion

