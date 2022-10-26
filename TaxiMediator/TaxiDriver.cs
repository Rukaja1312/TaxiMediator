namespace TaxiMediator;

public abstract class TaxiDriver
{
    public TaxiDriver(string carNumber)
    {
        CarNumber = carNumber;
    }

    public string CarNumber { get; set; }
    public bool IsBusy { get; set; } = false; 
    
    public abstract void Send(string carNumber);
    public abstract void Receive(string message);
}