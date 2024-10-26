namespace AbstractFactory.DesignPattern.Abstraction;

public interface IMealSetFactory
{
    public IDrink GetDrink();
    
    public IMeal GetMeal();
}