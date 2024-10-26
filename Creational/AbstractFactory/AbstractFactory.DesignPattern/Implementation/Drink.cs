using AbstractFactory.DesignPattern.Abstraction;

namespace AbstractFactory.DesignPattern.Implementation;

public class Drink(string name, int amountInMl) : IDrink
{
    public Drink() : this("Orange juice", 200)
    {
    }

    public string GetDrinkDescription()
    {
        return $"Drink: {name}, amount: {amountInMl} ml.";
    }
}