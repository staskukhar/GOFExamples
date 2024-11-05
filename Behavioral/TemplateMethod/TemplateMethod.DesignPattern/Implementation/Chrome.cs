using TemplateMethod.DesignPattern.Abstraction;

namespace TemplateMethod.DesignPattern.Implementation;

public class Chrome : Browser
{
    protected override void StartSearchEngine()
    {
        Console.WriteLine("Starting the Google engine...");
    }
}