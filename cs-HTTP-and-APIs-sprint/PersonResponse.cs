using System.Text.Json.Serialization;

namespace cs_HTTP_and_APIs_sprint;

internal class PersonResponse
{
    [JsonPropertyName("status")]
    public string? Status { get; set; }
    [JsonPropertyName("code")]
    public int Code { get; set; } 
    [JsonPropertyName("data")]
    public List<Person>? Persons { get; set; } 
}
