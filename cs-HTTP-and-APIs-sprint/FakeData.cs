using System.Text.Json;

namespace cs_HTTP_and_APIs_sprint;

internal class FakeData
{
    private static readonly string PERSON_URL = "https://fakerapi.it/api/v2/persons?_quantity=5";
    private static readonly string BOOK_URL = "https://fakerapi.it/api/v2/books?_quantity=5";

    public static async Task<PersonResponse?> GetAllPersonsAsync()
    {
        using HttpClient client = new HttpClient();
        try
        {
            HttpResponseMessage response = await client.GetAsync(PERSON_URL);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            if (!string.IsNullOrEmpty(responseBody))
            {
                return JsonSerializer.Deserialize<PersonResponse>(responseBody);
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

    public static async Task<BookResponse?> GetBooks()
    {
        try
        {

            using HttpClient client = new HttpClient();
            var response = await client.GetAsync(BOOK_URL);
            response.EnsureSuccessStatusCode();

            string? responseBody = await response.Content.ReadAsStringAsync();
            if (!string.IsNullOrEmpty(responseBody))
            {
                return JsonSerializer.Deserialize<BookResponse>(responseBody);
            }
            else
            {
                Console.WriteLine("Could not be deserialised");
                return null;
            }
        }
        catch(HttpRequestException ex)
        {
            Console.WriteLine(ex.Message);
        }
        return null;


    }
}
