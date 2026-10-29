

namespace PostmanCloneLib
{
    public interface IApiAcces
    {
       
        Task<string> CallApiAsync(string url, string content, HttpAction action = HttpAction.GET, bool formatOutput = true);
        Task<string> CallApiAsync(string url, HttpContent? content = null, HttpAction action = HttpAction.POST, bool formatOutput = true);
        bool IsValidUrl(string url);
    }
}