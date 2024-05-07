namespace Entities
{
    public class Hr : Employee
    {
        #region Data members
        private decimal gratuityPayment;
        #endregion

        #region Constructors
        public Hr() { }

        public Hr(int id, string? name = null, decimal basicPayment = 0, decimal daPayment = 0, decimal hraPayment = 0, decimal gratuityPayment=0)
            : base(id, name, basicPayment, daPayment, hraPayment)
        {
            this.gratuityPayment = gratuityPayment;
        }
        #endregion

        #region Properties
        public decimal GratuityPayment
        {
            set => gratuityPayment = value;
            get => gratuityPayment;
        }
        #endregion

        #region Methods
        public override void CalculateSalary()
        {
            base.CalculateSalary();
            this.TotalPayment += gratuityPayment;
        }
        #endregion
    }
}
