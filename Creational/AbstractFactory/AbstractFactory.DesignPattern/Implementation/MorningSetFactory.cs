using AbstractFactory.DesignPattern.Abstraction;

namespace AbstractFactory.DesignPattern.Implementation;

public class MorningSetFactory : IMealSetFactory
{
    public IDrink GetDrink()
    {
        return new Drink();
    }

    public IMeal GetMeal()
    {
        return new Meal("Omelet", 300);
    }
}