namespace TemplateMethod.DesignPattern.Abstraction;

public abstract class Browser
{
    protected abstract void StartSearchEngine();

    protected virtual void FormatThePrompt(string prompt)
    {
        Console.WriteLine($"Formating the prompt: {prompt}...");
    }

    protected virtual void StructureResults()
    {
        Console.WriteLine("Results structuring...");
    }

    public void Search(string propmt)
    {
        StartSearchEngine();
        FormatThePrompt(propmt);
        Console.WriteLine($"Making request with prompt: {propmt}");
        StructureResults();
    }
}