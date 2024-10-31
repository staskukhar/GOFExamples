using Decorator.DesignPattern.Abstraction;

namespace Decorator.DesignPattern.Implementation;

public class PaymentCard : IPaymentCard
{
    public void ProcessPayment(decimal transactionSum)
    {
        Console.WriteLine($"Payment processed, transaction sum: {transactionSum}");
    }
}