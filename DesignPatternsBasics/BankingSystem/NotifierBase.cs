using System.Collections.Generic;

namespace BankingSystem
{
    public class NotifierBase : INotifier
    {
        private List<IObserver> _observers = new List<IObserver>();

        public void Notify(string content) =>
            _observers.ForEach(o => o.SendTextToClient(content));

        public void Subscribe(IObserver observer)
        {
            if (!_observers.Contains(observer)) _observers.Add(observer);
        }
    }
}
