using AbstractFactory.DesignPattern.Abstraction;

namespace AbstractFactory.DesignPattern.Implementation;

public class Meal(string name, int weightInGr) : IMeal
{
    public Meal() : this("Soup", 200)
    {
    }
    
    public string GetMealDescription()
    {
        return $"Meal: {name}, weight: {weightInGr} gr.";
    }
}