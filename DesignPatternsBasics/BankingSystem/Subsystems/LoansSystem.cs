using System;

namespace BankingSystem.Subsystems
{
    public class LoansSystem
    {
        private Account _account;

        public LoansSystem(Account account)
        {
            _account = account;
        }

        public void TakeLoan(double amount, LoanType type)
        {
            _account.ChangeBalance(amount);
            _account.Loans.Add(Loan.Create(amount, type));
        }

        public void PayOffLoans(Guid id, double amount)
        {
            _account.ChangeBalance(-amount);
            _account.Loans.Find(l => l.Id == id)?.PayOff(amount);
        }
    }
}
