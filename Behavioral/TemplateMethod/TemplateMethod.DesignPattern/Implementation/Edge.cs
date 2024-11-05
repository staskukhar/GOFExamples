using TemplateMethod.DesignPattern.Abstraction;

namespace TemplateMethod.DesignPattern.Implementation;

public class Edge : Browser
{
    protected override void StartSearchEngine()
    {
        Console.WriteLine("Starting the Bing engine...");
    }
}