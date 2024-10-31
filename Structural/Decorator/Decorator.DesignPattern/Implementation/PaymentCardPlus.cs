using Decorator.DesignPattern.Abstraction;

namespace Decorator.DesignPattern.Implementation;

public class PaymentCardPlus : IPaymentCard
{
    private readonly PaymentCard paymentCard = new PaymentCard();

    public void ProcessPayment(decimal transactionSum)
    {
        this.paymentCard.ProcessPayment(transactionSum);
        Console.WriteLine($"You have got {Math.Ceiling(transactionSum / 10):N0} points.");
    }
}