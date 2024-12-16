using System.Text.Json.Serialization;

namespace cs_HTTP_and_APIs_sprint;

internal class Person(string firstName, string lastName, string email, string phoneNumber, DateTime birthday, string gender)
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("firstname")]
    public string FirstName { get; set; } = firstName;
    [JsonPropertyName("lastname")]
    public string LastName { get; set; } = lastName;
    [JsonPropertyName("email")]
    public string Email { get; set; } = email;
    [JsonPropertyName("phone")]
    public string PhoneNumber { get; set; } = phoneNumber;
    [JsonPropertyName("birthday")]
    public DateTime Birthday { get; set; } = birthday;
    [JsonPropertyName("gender")]
    public string Gender { get; set; } = gender;
}
