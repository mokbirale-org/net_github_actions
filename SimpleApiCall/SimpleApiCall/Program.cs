// See https://aka.ms/new-console-template for more information

class Program
{
    static async Task Main(string[] args)
    {
        string apiUrl = "https://github.com/mokbirale-org/net_github_actions";
        string apiKey = Environment.GetEnvironmentVariable("API_KEY");
        
        using HttpClient client = new HttpClient();
        client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
        
        using HttpResponseMessage response = await client.GetAsync(apiUrl);
        if (response.IsSuccessStatusCode)
        {
            string content  = await response.Content.ReadAsStringAsync();
            Console.WriteLine("API Response " + content);
        }
        else
        {
            Console.WriteLine($"Error: {response.StatusCode}");
            
        }
    }
}