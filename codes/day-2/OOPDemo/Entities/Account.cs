using System.Xml.Linq;

namespace Entities
{
    /*
    public class Account
    {
        string? name;
        readonly int accId;
        decimal balance;
        static readonly string bankName = "ICICI";
        //static readonly string bankName;

        //const data member should be assigned through field initialization technique only
        public const string BANK_BRANCH = "Electronic City";

        //no access specifier
        //only static data can be assigned here
        //this ctor is called implicitly
        //this ctor is called only one time, before every other ctor and the very fisrt time an instance of the class has been created or any static member of the class has been invoked
        static Account()
        {
            bankName = "ICICI";
        }

        public Account() { }

        public Account(int accId, string? name = null, decimal balance = 0)
        {
            this.name = name;
            this.accId = accId;
            this.balance = balance;
        }

        //public void SetName(string name)
        //{
        //    this.name = name;
        //}
        //public string? GetName()
        //{
        //    return this.name;
        //}

        public static string? BankName
        {
            //set { bankName = value; }
            get { return bankName; }
        }

        public string? Name
        {
            //public void SetName(string name)
            //value => auto-declared parameter, ONLY for set accessor (function)
            //by default set and get accessor's access specifier is "public"
            set
            {
                this.name = value;
            }
            //public string? GetName()
            get
            {
                return this.name;
            }
        }

        //read-only property
        public int AccId
        {
            //set { accId = value; }
            get { return accId; }
        }

        public decimal Balance
        {
            get { return balance; }
            private set { balance = value; }
        }

        public void Credit(decimal amount)
        {
            Balance += amount;
        }
        public string GetInformation()
        {
            return $"{name}, {accId}, {balance}";
        }
    }
    */

    public class Account
    {
        #region data members
        public const string BANK_BRANCH = "Electronic City";
        private readonly int accId;
        #endregion

        #region properties
        //automatic properties or auto-implemented properties
        public string? Name { get; set; }
        public decimal? Balance { get; private set; }

        //public int AccId { get {return  accId;} }
        //public int AccId { get => accId; }

        //expression body syntax for read-only property
        public int AccId => accId;
        #endregion

        #region constructors
        public Account() { }

        public Account(int accId, string? name = null, decimal? balance = 0)
        {
            this.accId = accId;
            Name = name;
            Balance = balance;
        }
        #endregion

        #region methods
        //expression body syntax for method which returns a value
        public string GetInformation() => $"{Name}, {accId}, {Balance}";

        //expression body syntax for method which returns nothing
        public void Credit(decimal amount) => Balance += amount;
        #endregion
    }
}
