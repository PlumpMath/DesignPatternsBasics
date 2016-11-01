namespace BankingSystem.Subsystems
{
    public class TransfersSystem : NotifierBase, INotifier
    {
        private Account _account;

        public TransfersSystem(Account account)
        {
            _account = account;
        }

        public void SendTransfer(double amount)
        {
            _account.ChangeBalance(-amount);
            Notify($"Transfer has been sent. Amount: {amount}. Current balance: {_account.Balance}");
        }

        public void MakeDeposit(double amount)
        {
            _account.ChangeBalance(amount);
            Notify($"Deposit has been made. Amount: {amount}. Current balance: {_account.Balance}");
        }
    }
}
