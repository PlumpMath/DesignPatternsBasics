using BankingSystem.Investments;
using System.Collections.Generic;
using System;

namespace BankingSystem
{
    public class Account : IBankingProduct
    {
        private Account() { }
        public static Account GetEmptyAccount() => new Account();

        public double Balance { get; private set; } = 0;
        public double InterestRate { get; private set; } = 0;
        public List<Loan> Loans { get; private set; } = new List<Loan>();
        public List<Investment> Investments { get; private set; } = new List<Investment>();

        public void ChangeBalance(double balanceChange) => 
            Balance += balanceChange;

        public void SetInterestRate(double interestRate)
        {
            InterestRate = interestRate;
        }

        public TransactionSystem GetTransactionSystem()
        {
            return new TransactionSystem(this);
        }

        public void Evaluate()
        {
            Balance *= (1 + InterestRate);
            Loans.ForEach(l => l.Evaluate());
            Investments.ForEach(i => i.Evaluate());
        }
    }
}
