using System.Text.Json.Serialization;

namespace cs_HTTP_and_APIs_sprint;

internal class GetPersonResponse(string status, int code, List<Person> persons)
{
    [JsonPropertyName("status")]
    public string Status { get; set; } = status;
    [JsonPropertyName("code")]
    public int Code { get; set; } = code;
    [JsonPropertyName("data")]
    public List<Person> Persons { get; set; } = persons;
}
