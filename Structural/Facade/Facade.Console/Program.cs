using Facade.DesignPattern.Abstraction;
using Facade.DesignPattern.Implementation;

IWeatherForecastFacade facade = new WeatherForecastFacade();
facade.GetWeatherForecast(); 