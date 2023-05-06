using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Light_Cream;

public class DiscordSupport
{
    private HttpClient httpClient = new HttpClient();


    public async Task SendWebhook(string url, string message)
    {
        var payload = new { content = message }; 

        StringContent data = new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json");

        await httpClient.PostAsync(url, data);
    }

} 