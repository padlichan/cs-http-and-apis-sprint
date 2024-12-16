using System.Text.Json;

namespace cs_HTTP_and_APIs_sprint;

internal class FakeData
{
    private static readonly string PERSON_URL = "https://fakerapi.it/api/v2/persons?_quantity=";
    private static readonly string BOOK_URL = "https://fakerapi.it/api/v2/books?_quantity=";

    public static async Task<PersonResponse?> GetPersonsAsync(int numberOfPersons)
    {
        using HttpClient client = new HttpClient();
        try
        {
            HttpResponseMessage response = await client.GetAsync(PERSON_URL+numberOfPersons);
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

    public static async Task<BookResponse?> GetBooksAsync(int numberOfBooks)
    {
        try
        {

            using HttpClient client = new HttpClient();
            var response = await client.GetAsync(BOOK_URL+numberOfBooks);
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
