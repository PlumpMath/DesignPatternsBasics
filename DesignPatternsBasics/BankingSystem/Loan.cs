using System;

namespace BankingSystem
{
    public enum LoanType
    {
        Consumption,
        Car,
        Mortgage
    }

    public class Loan : IBankingProduct
    {
        public static Loan Create(double amount, LoanType loanType)
        {
            var loan = new Loan();
            loan.Id = Guid.NewGuid();
            loan.Balance = amount;
            switch (loanType)
            {
                case LoanType.Consumption:
                    loan.InterestRate = 0.1;
                    break;
                case LoanType.Car:
                    loan.InterestRate = 0.07;
                    break;
                case LoanType.Mortgage:
                    loan.InterestRate = 0.04;
                    break;
                default:
                    throw new Exception("Unknown loan type");
            }
            return loan;
        }

        public Guid Id { get; private set; }

        public double Balance { get; private set; }

        public double InterestRate { get; private set; }

        public void Evaluate()
        {
            Balance *= (1 + InterestRate);
        }
    }
}
