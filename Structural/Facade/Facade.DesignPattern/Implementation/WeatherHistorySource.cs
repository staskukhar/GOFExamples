using Facade.DesignPattern.Abstraction;

namespace Facade.DesignPattern.Implementation;

public class WeatherHistorySource: IWeatherHistorySource
{
    public void LoadWeatherHistory()
    {
        Console.WriteLine("Loading weather history...");
        Thread.Sleep(200 * Random.Shared.Next(10));
    }
}