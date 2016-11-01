using BankingSystem.Investments;
using System.Collections.Generic;

namespace BankingSystem
{
    class Account
    {
        private Account() { }
        public static Account GetEmptyAccount() =>
            new Account();

        public double Balance { get; private set; } = 0;
        public List<Loan> Loans { get; private set; } = new List<Loan>();
        public List<Investment> Investments { get; private set; } = new List<Investment>();

        public void AddToBalance(double initialBalance) => 
            Balance += initialBalance;
    }
}
