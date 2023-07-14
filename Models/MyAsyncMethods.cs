namespace LanguageFeatures.Models;

public class MyAsyncMethods
{
    //public static Task<long?> GetPageLenght()//asynchromous method without await/await
    //{
    //    HttpClient client = new HttpClient();
    //    var httpTask = client.GetAsync("http://apress.com");
    //    return httpTask.ContinueWith((Task<HttpResponseMessage> antecedent) => { return antecedent.Result.Content.Headers.ContentLength; });
    //}
    public async static Task<long?> GetPageLenght()//asynchromous method with await/await to work with asynchronous enumerable
    {
        HttpClient client = new HttpClient();
        var httpMessage = await client.GetAsync("http://apress.com");
        return httpMessage.Content.Headers.ContentLength;
    }
    //public static async Task<IEnumerable<long?>> GetPageLengths(List<string> output,params string[] urls)
    //{
    //    List<long?> results = new List<long?>();
    //    HttpClient client = new HttpClient();
    //    foreach(string url in urls)
    //    {
    //        output.Add($"Started request for {url}");
    //        var httpMessage=await client.GetAsync($"http://{url}");
    //        results.Add(httpMessage.Content.Headers.ContentLength);
    //        output.Add($"Completed request for {url}");            
    //    }
    //    return results;
    //}
    public static async IAsyncEnumerable<long?> GetPageLengths(List<string> output, params string[] urls)
    {
        HttpClient client = new HttpClient();
        foreach (string url in urls)
        {
            output.Add($"Started request for {url}");
            var httpMessage = await client.GetAsync($"http://{url}");
            output.Add($"Completed request for {url}");
            yield return httpMessage.Content.Headers.ContentLength;
        }
    }
}
