namespace Entities
{
    public class Developer : Employee
    {
        #region Data members
        private decimal incentivePayment;
        #endregion

        #region Constructors
        public Developer() { }

        public Developer(int id, string? name = null, decimal basicPayment = 0, decimal daPayment = 0, decimal hraPayment = 0, decimal incentivePayment = 0)
            : base(id, name, basicPayment, daPayment, hraPayment)
        {
            this.incentivePayment = incentivePayment;
        }
        #endregion

        #region Properties
        public decimal IncentivePayment
        {
            set => incentivePayment = value;
            get => incentivePayment;
        }
        #endregion

        #region Methods
        public override void CalculateSalary()
        {
            base.CalculateSalary();
            this.TotalPayment += incentivePayment;
        }
        #endregion
    }
}
