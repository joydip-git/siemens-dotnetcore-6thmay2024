namespace Entities
{
    public class Account
    {
        public Account()
        {
            Console.WriteLine("default ctor of Account");
        }

        public Account(int id, string? name, decimal balance)
        {
            Console.WriteLine("parameterized ctor of Account");
            //this.id = id;
            //this.name = name;
            //this.balance = balance;
            Id = id;
            Name = name;
            Balance = balance;
        }

        /*
        private int id;
        private string? name;
        private decimal balance;

        public int Id { get => id; set => id = value; }
        public string? Name { get => name; set => name = value; }
        public decimal Balance
        {
            get => balance;
            protected set
            {
                if (value < 0)
                {
                    throw new ArithmeticException("value can't be negative");
                }
                balance = value;
            }
        }
        */

        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Balance { get; protected set; }

        public void Credit(decimal amount) => Balance += amount;
    }
}
