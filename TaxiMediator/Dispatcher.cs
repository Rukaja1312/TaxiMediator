namespace TaxiMediator;

public class Dispatcher : IMediator
{
    protected List<TaxiDriver> taxiDrivers = new List<TaxiDriver>();
    
    private void CompanyCars()
    {
        
    }

    public void Add()
    {
        taxiDrivers.Add(new ConcretTaxiDriver("1"));
        taxiDrivers.Add(new ConcretTaxiDriver("2"));
        taxiDrivers.Add(new ConcretTaxiDriver("3"));
        taxiDrivers.Add(new ConcretTaxiDriver("4"));
        taxiDrivers.Add(new ConcretTaxiDriver("5"));
        taxiDrivers.Add(new ConcretTaxiDriver("6"));
        taxiDrivers.Add(new ConcretTaxiDriver("7"));
    }
    
    public void SendMessage(string msg)
    {
        foreach (var taxi in taxiDrivers)
        {
            taxi.Receive(msg);
        }
        Console.WriteLine($"Dispatcher: Free car in zone {msg}");
    }

    public void TaxiIsBusy()
    {
        var taxi = taxiDrivers.Where(x=>x.IsBusy==false).FirstOrDefault();
        if (taxi!=null)
        {
            taxi.IsBusy = true;
            taxi.Send(taxi.CarNumber);
        }
        else
        {
            Console.WriteLine("We don`t have a free car.");
        }
        
    }
}