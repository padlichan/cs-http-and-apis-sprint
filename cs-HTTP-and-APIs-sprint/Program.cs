using System.Data;
using cs_HTTP_and_APIs_sprint;

var result = await FakeData.GetAllPersonsAsync();
result?.Persons.ForEach(p => Console.WriteLine($"{p.FirstName} {p.LastName}"));