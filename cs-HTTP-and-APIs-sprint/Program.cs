using System.Data;
using cs_HTTP_and_APIs_sprint;

var personResult = await FakeData.GetPersonsAsync(5);
personResult?.Persons?.ForEach(p => Console.WriteLine($"{p.FirstName} {p.LastName}"));
Console.WriteLine();

var bookResult = await FakeData.GetBooksAsync(2);
bookResult?.Books?.ForEach(b => Console.WriteLine(b.Title));