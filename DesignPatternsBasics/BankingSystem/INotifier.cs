namespace BankingSystem
{
    public interface INotifier
    {
        void Notify(string content);
        void Subscribe(IObserver observer);
    }
}
