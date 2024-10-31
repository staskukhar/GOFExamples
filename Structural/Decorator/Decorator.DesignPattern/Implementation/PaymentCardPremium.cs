using Decorator.DesignPattern.Abstraction;

namespace Decorator.DesignPattern.Implementation;

public class PaymentCardPremium : IPaymentCard
{
    private readonly PaymentCardPlus paumentCard = new PaymentCardPlus();

    public void ProcessPayment(decimal transactionSum)
    {
        this.paumentCard.ProcessPayment(transactionSum);
        Console.WriteLine($"You have returned {Math.Ceiling(transactionSum / 20):N0} as cash back.");
    }
}