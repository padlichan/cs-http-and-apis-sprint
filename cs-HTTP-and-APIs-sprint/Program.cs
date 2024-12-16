namespace cs_HTTP_and_APIs_sprint;

internal class Program
{
    static void Main(string[] args)
    {
        HttpClient client = new HttpClient();
    }
}

internal class FakeData
{
    private static readonly string BASE_URL = "https://fakerapi.it/api/v2/persons";
}
