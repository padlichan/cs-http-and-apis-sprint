using System.Text.Json;

namespace cs_HTTP_and_APIs_sprint;

internal class FakeData
{
    private static readonly string BASE_URL = "https://fakerapi.it/api/v2/persons?_quantity=5";

    public static async Task<GetPersonResponse?> GetAllPersonsAsync()
    {
        using HttpClient client = new HttpClient();
        try
        {
            HttpResponseMessage response = await client.GetAsync(BASE_URL);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            if (!string.IsNullOrEmpty(responseBody))
            {
                return JsonSerializer.Deserialize<GetPersonResponse>(responseBody);
            }
            else
            {
                Console.WriteLine("Could not be deserialised");
                return null;
            }
        }
        catch (HttpRequestException error)
        {
            Console.WriteLine(error.Message);
        }
        return null;
    }
}
