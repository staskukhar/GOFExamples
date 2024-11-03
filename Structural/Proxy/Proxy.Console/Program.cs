using Proxy.DesignPattern.Abstraction;
using Proxy.DesignPattern.Implementation;

ISuspect client = new Suspect();

ISuspect lawyer = new Lawyer(client); 

IPolice police = new Police(lawyer);

police.AskTrueFalseQuestion("Can someone confirm this fact?");
police.AskTrueFalseQuestion("Have you ever seen the person?");
police.AskTrueFalseQuestion("Do you know the person?");
police.AskTrueFalseQuestion("Have you ever been to the place?");