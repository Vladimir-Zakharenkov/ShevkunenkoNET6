namespace LanguageFeatures.Models;

public class MyAsyncMethods
{
    #region Example1
    //public static Task<long?> GetPageLength()
    //{
    //    HttpClient client = new HttpClient();
    //    var httpTask = client.GetAsync("http://apress.com");
    //    return httpTask.ContinueWith((Task<HttpResponseMessage> antecedent) =>
    //    {
    //        return antecedent.Result.Content.Headers.ContentLength;
    //    });
    //}
    #endregion

    #region Example2
    public async static Task<long?> GetPageLength()
    {
        HttpClient client = new HttpClient();

        var httpMessage = await client.GetAsync("http://apress.com");

        return httpMessage.Content.Headers.ContentLength;
    }
    #endregion
}
