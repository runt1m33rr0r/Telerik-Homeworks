namespace _02_BankAccounts.Accounts
{
    using System;
    using Enumerations;
    using Interfaces;

    public class Mortgage : Account, IDepositable
    {
        public Mortgage(CustomerType accCustomer, decimal accBalance, decimal accInterestRate) : base(accCustomer, accBalance, accInterestRate)
        {
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("The amount of money can not be less or equal to 0!");
            }

            this.Balance += amount;
        }

        public override decimal CalculateInterest(int months)
        {
            decimal result = 0M;

            if (months <= 0)
            {
                throw new ArgumentException("The months can not be negative!");
            }

            if (this.AccountCustomer == CustomerType.Company && months > 12)
            {
                result = ((12 * (this.InterestRate / 100)) / 2) + ((months - 12) * (this.InterestRate / 100));
            }
            else if (this.AccountCustomer == CustomerType.Individual && months > 6)
            {
                result = (months - 6) * (this.InterestRate / 100);
            }

            return result;
        }  
    }
}
