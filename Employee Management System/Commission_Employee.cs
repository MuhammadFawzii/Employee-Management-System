namespace Employee_Management_Application
{
    internal class Commission_Employee : Employee
    {
        private const double commissionRate = 0.05;
        private double targetCommissionRate;
        public double TargetCommissionRate
        {
            set
            {
                if (value < 0)
                    throw new ArgumentException("Commission Rate must be greater than 0", nameof(targetCommissionRate));
                targetCommissionRate = value;
            }
            get { return targetCommissionRate; }
        }
        public Commission_Employee(int _id, string _name, string _phone, string _email, Department _department, TypeOfEmployee _typeOfEmployee, string _SSN, double targetCommissionRate) : base(_id, _name, _phone, _email, _department, _typeOfEmployee, _SSN)
        {
            this.TargetCommissionRate = targetCommissionRate;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nTarget Commission Rate : {TargetCommissionRate}";

        }
        public override string Print()
        {
            return base.Print();
        }
        public override double Pay()
        {
            return commissionRate * targetCommissionRate;
        }
    }
}
