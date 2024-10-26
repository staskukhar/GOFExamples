using AbstractFactory.DesignPattern.Abstraction;

namespace AbstractFactory.DesignPattern.Implementation;

public class EveningSetFactory : IMealSetFactory
{
    public IDrink GetDrink()
    {
        return new Drink("Milk", 150);
    }

    public IMeal GetMeal()
    {
        return new Meal("Granola", 200);
    }
}