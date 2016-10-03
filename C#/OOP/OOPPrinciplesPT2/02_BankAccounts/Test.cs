namespace _02_BankAccounts
{
    using System;
    using Accounts;
    using Enumerations;

    public class Test
    {
        public static void Main()
        {
            DepositAcc depAcc = new DepositAcc(CustomerType.Company, 12000, 2);
            Loan loanAcc = new Loan(CustomerType.Individual, 4500, 3);
            Mortgage mortAcc = new Mortgage(CustomerType.Company, 500000, 4);

            Console.WriteLine(depAcc.CalculateInterest(10));
            Console.WriteLine(loanAcc.CalculateInterest(10));
            Console.WriteLine(mortAcc.CalculateInterest(10));
        }
    }
}
