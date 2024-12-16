using System.Text.Json.Serialization;

namespace cs_HTTP_and_APIs_sprint;

internal class Person
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("firstname")]
    public string? FirstName { get; set; } 
    [JsonPropertyName("lastname")]
    public string? LastName { get; set; }
    [JsonPropertyName("email")]
    public string? Email { get; set; }
    [JsonPropertyName("phone")]
    public string? PhoneNumber { get; set; } 
    [JsonPropertyName("birthday")]
    public DateTime? Birthday { get; set; } 
    [JsonPropertyName("gender")]
    public string? Gender { get; set; } 
}
