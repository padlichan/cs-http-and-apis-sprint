using System.Text.Json;

namespace cs_HTTP_and_APIs_sprint;

internal class FlightData
{
    private static readonly string BASE_URL = "https://api.schiphol.nl/public-flights/flights";
    public static async Task<FlightResponse?> GetFlightData()
    {
        try
        {
            using HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("app_id", "d8fddb41");
            client.DefaultRequestHeaders.Add("app_key", "5ad52e4c027408b0cd84388c2ffe109b");
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("ResourceVersion", "v4");

            var response = await client.GetAsync(BASE_URL);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            if (!string.IsNullOrEmpty(responseBody))
            {
                return JsonSerializer.Deserialize<FlightResponse>(responseBody);
            }
            else
            {
                Console.WriteLine("Could not be deserialised");
                return null;
            }
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine(ex.Message);
        }
        return null;
    }
}