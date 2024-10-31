using Decorator.DesignPattern.Abstraction;
using Decorator.DesignPattern.Implementation;

IPaymentCard plainCard = new PaymentCard();
plainCard.ProcessPayment(400m);
Console.WriteLine();

IPaymentCard cardPlus = new PaymentCardPlus();
cardPlus.ProcessPayment(200m);
Console.WriteLine();

IPaymentCard premiumCard = new PaymentCardPremium();
premiumCard.ProcessPayment(800m);