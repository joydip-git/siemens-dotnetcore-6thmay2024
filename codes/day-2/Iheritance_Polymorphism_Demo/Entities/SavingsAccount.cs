namespace Entities
{
    public class SavingsAccount : Account
    {
        //private decimal <SavingsAccInterestRate>k_BackingField;
        public decimal SavingsAccInterestRate { get; set; }
        public SavingsAccount()
        {
            Console.WriteLine("default ctor of SA");
        }
        public SavingsAccount(int accId, string? name, decimal balance, decimal savingsAccInterestRate)
            : base(accId, name, balance)
        {
            //Id = accId;
            //Name = name;
            //Balance = balance;
            Console.WriteLine("parameterized ctor of SA");
            SavingsAccInterestRate = savingsAccInterestRate;
        }
    }
}
