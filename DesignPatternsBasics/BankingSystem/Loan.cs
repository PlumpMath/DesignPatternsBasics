using System;

namespace BankingSystem
{
    class Loan
    {
        public static Loan Create(double amount)
        {
            return new Loan
            {
                Id = Guid.NewGuid(),
                Balance = amount
            };
        }

        public Guid Id { get; private set; }

        public double Balance { get; private set; }
    }
}
