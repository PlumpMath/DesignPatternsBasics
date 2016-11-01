namespace BankingSystem
{
    public interface IObserver
    {
        void SendTextToClient(string content);
    }
}
