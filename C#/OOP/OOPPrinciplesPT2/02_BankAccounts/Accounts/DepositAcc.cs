namespace _02_BankAccounts.Accounts
{
    using System;
    using Enumerations;
    using Interfaces;

    public class DepositAcc : Account, IDepositable, IWithdrawable
    {
        public DepositAcc(CustomerType accCustomer, decimal accBalance, decimal accInterestRate) : base(accCustomer, accBalance, accInterestRate)
        {
        }

        public void WithDraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("The amount of money can not be less or equal to 0!");
            }
            else if (amount > this.Balance)
            {
                throw new ArgumentException("You can not withdraw more than your balance!");
            }

            this.Balance -= amount;
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

            if (this.Balance > 0 && this.Balance < 1000)
            {
                result = 0;
            }
            else if (this.Balance >= 1000)
            {
                result = (this.InterestRate / 100) * months;
            }

            return result;
        }
    }
}
