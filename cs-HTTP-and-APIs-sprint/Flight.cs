using System.Text.Json.Serialization;

namespace cs_HTTP_and_APIs_sprint;

internal class Flight
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
    [JsonPropertyName("flightName")]
    public string FlightName {  get; set; }
    [JsonPropertyName("scheduleDate")]
    public DateTime ScheduledDate { get; set; }
    [JsonPropertyName("terminal")]
    public int Terminal { get; set; }
    [JsonPropertyName("actualLandingTime")]
    public DateTime ActualLandingTime { get; set; }
    [JsonPropertyName("aircraftType")]
    public AircraftType AircraftType { get; set; }
    [JsonPropertyName("route")]
    public Route Route { get; set; }
}
public class AircraftType
{
    [JsonPropertyName("iataMain")]
    public string IataMain { get; set; }

    [JsonPropertyName("iataSub")]
    public string IataSub { get; set; }
}

public class Route
{
    [JsonPropertyName("destinations")]
    public string[] Destinations { get; set; }
    [JsonPropertyName("eu")]
    public string Eu { get; set; }
    [JsonPropertyName("visa")]
    public bool visa { get; set; }
}

internal class FlightResponse
{
    [JsonPropertyName("flights")]
    public List<Flight> Flights {  get; set; }
}