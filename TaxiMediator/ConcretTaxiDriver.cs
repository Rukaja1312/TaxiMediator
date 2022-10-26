namespace TaxiMediator;

public class ConcretTaxiDriver : TaxiDriver
{
    public ConcretTaxiDriver( string carNumber) 
        : base(carNumber)
    {
    }

    public override void Send(string carNumber)
    {
        Console.WriteLine($"Taxi: Car number {carNumber} leaves.");
    }

    public override void Receive(string message)
    {
        
    }
}