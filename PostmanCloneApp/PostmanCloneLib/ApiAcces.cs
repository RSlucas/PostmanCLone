
using System.Text.Json;
using System.Threading.Tasks;

namespace PostmanCloneLib;

public class ApiAcces
{
    private readonly HttpClient client = new();
    public async Task<string> CallApiAsync(string url)
    {
        var response = await client.GetAsync(url);

        if(response.IsSuccessStatusCode)
        {
            string json = await response.Content.ReadAsStringAsync();
            var jsonElement = JsonSerializer.Deserialize<JsonElement>(json);
            string okjson = JsonSerializer.Serialize(jsonElement,
                new JsonSerializerOptions { WriteIndented = true });

            return okjson;
        }
        else
        {
            return $"Error : {response.StatusCode}";
        }
    }
}
