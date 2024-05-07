namespace Entities
{
    public class Employee
    {
        #region Data Members
        private readonly int id;
        private string? name;
        private decimal basicPayment;
        private decimal daPayment;
        private decimal hraPayment;
        private decimal totalPayment;
        #endregion

        #region Constructors
        public Employee() { }

        public Employee(int id, string? name = null, decimal basicPayment = 0, decimal daPayment = 0, decimal hraPayment = 0)
        {
            this.id = id;
            this.name = name;
            this.basicPayment = basicPayment;
            this.daPayment = daPayment;
            this.hraPayment = hraPayment;
            totalPayment = 0;
        }
        #endregion

        #region Properties
        public int Id => id;

        public string? Name
        {
            get => name; set => name = value;
        }
        public decimal BasicPayment
        {
            get => basicPayment; set => basicPayment = value;
        }
        public decimal DaPayment
        {
            get => daPayment; set => daPayment = value;
        }
        public decimal HraPayment
        {
            get => hraPayment; set => hraPayment = value;
        }
        public decimal TotalPayment
        {
            get => totalPayment;
            protected set => totalPayment = value;
        }
        #endregion

        #region Methods
        public virtual void CalculateSalary()
        {
            this.totalPayment = basicPayment + hraPayment + daPayment;
        }
        #endregion
    }
}
