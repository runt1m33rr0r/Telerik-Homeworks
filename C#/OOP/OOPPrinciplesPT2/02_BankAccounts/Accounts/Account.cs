namespace _02_BankAccounts.Accounts
{
    using System;
    using Enumerations;

    public abstract class Account
    {
        private CustomerType accountCustomer;
        private decimal accountBalance;
        private decimal interestRate;

        public Account(CustomerType accCustomer, decimal accBalance, decimal accInterestRate)
        {
            this.AccountCustomer = accCustomer;
            this.Balance = accBalance;
            this.InterestRate = accInterestRate;
        }

        protected CustomerType AccountCustomer { get; set; }

        protected decimal Balance
        {
            get
            {
                return this.accountBalance;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The balance can not be negative!");
                }

                this.accountBalance = value;
            }
        }

        protected decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The interest rate must be a positive number!");
                }

                this.interestRate = value;
            }
        }

        public abstract decimal CalculateInterest(int months);
    }
}
