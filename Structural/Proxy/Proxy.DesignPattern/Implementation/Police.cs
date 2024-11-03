using Proxy.DesignPattern.Abstraction;

namespace Proxy.DesignPattern.Implementation;

public class Police(ISuspect suspect) : IPolice
{
    private ISuspect Suspect { get; init; } = suspect;

    public void AskTrueFalseQuestion(string question)
    {
        Console.WriteLine(
            this.Suspect.AnswerTrueFalseQuestion(question));
    }
}