using Proxy.DesignPattern.Abstraction;

namespace Proxy.DesignPattern.Implementation;

public class Suspect : ISuspect
{
    public string AnswerTrueFalseQuestion(string question)
    {
        return $"{question}: {(Random.Shared.Next(2) == 1 ? "Yes" : "No")}";
    }
}