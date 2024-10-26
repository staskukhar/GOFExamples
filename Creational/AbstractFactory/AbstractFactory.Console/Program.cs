using AbstractFactory.DesignPattern.Abstraction;
using AbstractFactory.DesignPattern.Implementation;

ProcessMealFactory(new MorningSetFactory());
ProcessMealFactory(new LunchSetFactory());
ProcessMealFactory(new EveningSetFactory());

void ProcessMealFactory(IMealSetFactory mealFactory)
{
    Console.WriteLine($"Meal factory: {mealFactory.GetType().Name}");
    
    Console.WriteLine(
        mealFactory.GetDrink().GetDrinkDescription());
    Console.WriteLine(
        mealFactory.GetMeal().GetMealDescription());
    Console.WriteLine();
}