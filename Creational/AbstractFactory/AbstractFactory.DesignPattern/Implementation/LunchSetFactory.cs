using AbstractFactory.DesignPattern.Abstraction;

namespace AbstractFactory.DesignPattern.Implementation;

public class LunchSetFactory : IMealSetFactory
{
    public IDrink GetDrink()
    {
        return new Drink("Coffee", 200);
    }

    public IMeal GetMeal()
    {
        return new Meal("Soup", 250);
    }
}