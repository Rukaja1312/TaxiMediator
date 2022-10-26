namespace TaxiMediator;

public interface IMediator
{
    void SendMessage(string msg);
    void TaxiIsBusy();
}