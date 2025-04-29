using System.Text.Json;
using App.Core.Converters;
using Serilog;

namespace App.Services
{
    public abstract class ServiceBase
    {
        public async Task<T> Get<T>(HttpClient client, string url)
        {
            var response = await client.GetAsync(url);

            var content = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
                throw new Exception("Error calling Open Street Map API");

            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                PropertyNameCaseInsensitive = true
            };

            options.Converters.Add(new DoubleFromStringConverter());

            var result = JsonSerializer.Deserialize<T>(content, options);

            Log.Information("Service Qualification Response, {@result}", result);

            return result;
        }
    }
}
