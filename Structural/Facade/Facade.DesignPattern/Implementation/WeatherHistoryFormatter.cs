using Facade.DesignPattern.Abstraction;

namespace Facade.DesignPattern.Implementation;

public class WeatherHistoryFormatter: IWeatherHistoryFormatter
{
    public void FormatWeatherHistory()
    {
        Console.WriteLine("Formatting weather history...");
        Thread.Sleep(200 * Random.Shared.Next(10));
    }
}