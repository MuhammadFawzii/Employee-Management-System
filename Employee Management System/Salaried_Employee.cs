namespace Employee_Management_Application
{
    internal class Salaried_Employee : Employee
    {
        private double salary;
        public double Salary
        {
            private set
            {
                if (value < 0)
                    throw new ArgumentException("Salary must be greater than 0", nameof(Salary));
                salary = value;
            }
            get { return salary; }
        }
        public Salaried_Employee(int _id = 0, string _name = "Empty", string _phone = "Empty", string _email = "Empty", Department _department = null, TypeOfEmployee _typeOfEmployee = TypeOfEmployee.None, string _SSN = "Empty", double salary = 0.0) : base(_id, _name, _phone, _email, _department, _typeOfEmployee, _SSN)
        {
            this.Salary = salary;
        }



        public override string ToString()
        {
            return base.ToString() + $"\nSalary : {Salary}";

        }
        /// <summary>
        /// Pay method to calculate the pay of the employee
        /// </summary>
        /// <returns></returns>

        public override double Pay()
        {
            return Salary;
        }
        public override string Print()
        {
            return ToString();
        }
    }

}
