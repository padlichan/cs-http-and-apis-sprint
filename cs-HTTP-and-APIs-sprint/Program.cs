using System.Data;
using cs_HTTP_and_APIs_sprint;

var personResult = await FakeData.GetAllPersonsAsync();
//personResult?.Persons?.ForEach(p => Console.WriteLine($"{p.FirstName} {p.LastName}"));

var bookResult = await FakeData.GetBooks();
bookResult?.Books?.ForEach(b => Console.WriteLine(b.Title));