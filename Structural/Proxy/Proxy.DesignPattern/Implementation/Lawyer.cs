using Proxy.DesignPattern.Abstraction;

namespace Proxy.DesignPattern.Implementation;

public class Lawyer(ISuspect client) : ISuspect
{
    private ISuspect Client { get; init; } = client;
    
    public string AnswerTrueFalseQuestion(string question)
    {
        if (Random.Shared.Next(2) == 1)
        {
            return this.Client.AnswerTrueFalseQuestion(question);
        }

        return $"{question}: Declined!";
    }
}