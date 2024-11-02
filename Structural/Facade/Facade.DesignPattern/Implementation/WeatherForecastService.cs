using Facade.DesignPattern.Abstraction;

namespace Facade.DesignPattern.Implementation;

public class WeatherForecastService: IWeatherForecastService
{
    private string[] weatherConditions = ["Sunny", "Rain", "Thunderstorm", "Cloudy", "Fog", "Snow"];
    public void PredictWeatherConditions()
    {
        Console.WriteLine($"Weather: {this.weatherConditions[Random.Shared.Next(weatherConditions.Length - 1)]}");
    }
}