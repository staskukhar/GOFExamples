### Structural Design Pattern - Facade

Imagine a case when you need to predict weather conditions:
- get weather data for the last few months
- prepare the date
- analyze the data
- ...
- make a prediction

It would be good to use a service that manages all steps and provides a simple interface for a client.