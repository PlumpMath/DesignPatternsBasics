using System;

namespace BankingSystem.Subsystems
{
    public class LoansSystem : NotifierBase, INotifier
    {
        private Account _account;

        public LoansSystem(Account account)
        {
            _account = account;
        }

        public void TakeLoan(double amount, LoanType type)
        {
            var loan = Loan.Create(amount, type);
            _account.Loans.Add(loan);
            _account.ChangeBalance(amount);
            Notify($"Loans has been taken. Amount: {amount.ToString("F2")}, interest rate: {loan.InterestRate}");
        }

        public void PayLoan(Guid id, double amount)
        {
            var loan = _account.Loans.Find(l => l.Id == id);
            if (loan != null)
            {
                loan.PayOff(amount);
                _account.ChangeBalance(-amount);
                Notify($"Loans has been made. Amount paid: {amount.ToString("F2")}, outstanding balance: {loan.Balance}");
            }
        }
    }
}
