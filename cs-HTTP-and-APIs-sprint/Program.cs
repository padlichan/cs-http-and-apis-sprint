using System.Data;
using cs_HTTP_and_APIs_sprint;

//var flightResult = await FlightData.GetFlightData();

var flightResult = await FlightData.GetFlightData();
//Console.WriteLine(flightResult?.Flights?.Count);
flightResult.Flights.ForEach(f => Console.WriteLine($"ID: {f.Id} | Name : {f.FlightName,-6} | Scheduled: {f.ScheduledDate} | Eu: {f.Route.Eu}"));