using System.Security.Cryptography.X509Certificates;
using Facade.DesignPattern.Abstraction;

namespace Facade.DesignPattern.Implementation;

public class WeatherDataAnalyzer: IWeatherDataAnalyzer
{
    public void AnalyzeWeatherData()
    {
        Console.WriteLine("Analyzing weather data...");
        Thread.Sleep(200 * Random.Shared.Next(10));
    }
}