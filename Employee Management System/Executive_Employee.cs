namespace Employee_Management_Application
{
    internal class Executive_Employee : Salaried_Employee
    {
        private double bonus;
        public double Bonus
        {
            private set
            {
                if (value < 0)
                    throw new ArgumentException("Bonus must be greater than 0", nameof(Bonus));
                bonus = value;
            }
            get { return bonus; }
        }
        public Executive_Employee(int _id, string _name, string _phone, string _email, Department _department, TypeOfEmployee _typeOfEmployee, string _SSN, double salary, double bonus) : base(_id, _name, _phone, _email, _department, _typeOfEmployee, _SSN, salary)
        {
            this.Bonus = bonus;
        }
        public void addBonus(double bonus)
        {
            this.Bonus += bonus;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nBonus : {this.Bonus}";
        }
        public override string Print()
        {
            return ToString();
        }
        public override double Pay()
        {
            return Salary + Bonus;
        }
    }
}
