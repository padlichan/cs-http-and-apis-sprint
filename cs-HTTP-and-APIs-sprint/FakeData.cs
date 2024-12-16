namespace cs_HTTP_and_APIs_sprint;

internal class FakeData
{
    private static readonly string BASE_URL = "https://fakerapi.it/api/v2/persons?_quantity=5";

    public static async Task GetAllPersonsAsync()
    {
        using HttpClient client = new HttpClient();
        HttpResponseMessage response = await client.GetAsync(BASE_URL);
        string responseBody = await response.Content.ReadAsStringAsync();
        Console.WriteLine(responseBody);
    }
}
