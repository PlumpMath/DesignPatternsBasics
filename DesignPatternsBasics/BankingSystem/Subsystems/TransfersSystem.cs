namespace BankingSystem.Subsystems
{
    public class TransfersSystem
    {
        private Account _account;

        public TransfersSystem(Account account)
        {
            _account = account;
        }

        public void SendTransfer(double amount)
        {
            _account.ChangeBalance(-amount);
        }

        public void MakeDeposit(double amount)
        {
            _account.ChangeBalance(amount);
        }
    }
}
