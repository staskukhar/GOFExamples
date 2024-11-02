using Facade.DesignPattern.Abstraction;

namespace Facade.DesignPattern.Implementation;

public class WeatherForecastFacade: IWeatherForecastFacade
{
    public void GetWeatherForecast()
    {
        IWeatherHistorySource source = new WeatherHistorySource();
        source.LoadWeatherHistory();
        
        IWeatherHistoryFormatter formatter = new WeatherHistoryFormatter();
        formatter.FormatWeatherHistory();
        
        IWeatherDataAnalyzer analyzer = new WeatherDataAnalyzer();
        analyzer.AnalyzeWeatherData();

        IWeatherForecastService weatherForecastService = new WeatherForecastService();
        weatherForecastService.PredictWeatherConditions();
    }
}