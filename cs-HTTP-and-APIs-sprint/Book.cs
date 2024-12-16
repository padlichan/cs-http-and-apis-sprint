using System.Text.Json.Serialization;

namespace cs_HTTP_and_APIs_sprint;

internal class Book
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("title")]
    public string? Title { get; set; }
    [JsonPropertyName("author")]
    public string? Author { get; set; }
    [JsonPropertyName("published")]
    public DateTime? Published { get; set; }
}
