namespace Decorator.DesignPattern.Abstraction;

public interface IPaymentCard
{
    public void ProcessPayment(decimal transactionSum);
}