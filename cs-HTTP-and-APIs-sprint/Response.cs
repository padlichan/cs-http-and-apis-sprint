namespace cs_HTTP_and_APIs_sprint;

internal class Response(string status, int code, List<Person> persons)
{
    public string Status { get; set; } = status;
    public int Code { get; set; } = code;
    public List<Person> Persons { get; set; } = persons;
}
