namespace Employee_Management_Application
{
    internal class Hourly_Employee : Employee
    {
        private double hourlyRate;
        private double hoursWorked;
        public double HourlyRate
        {
            private set
            {
                if (value < 0)
                    throw new ArgumentException("Hourly Rate must be greater than 0", nameof(HourlyRate));
                hourlyRate = value;
            }
            get { return hourlyRate; }
        }
        public double HoursWorked
        {
            private set
            {
                if (value < 0)
                    throw new ArgumentException("Hours Worked must be greater than 0", nameof(HoursWorked));
                hoursWorked = value;
            }
            get { return hoursWorked; }
        }
        public Hourly_Employee(int _id, string _name, string _phone, string _email, Department _department, TypeOfEmployee _typeOfEmployee, string _SSN, double hoursWorked, double hourlyRate) : base(_id, _name, _phone, _email, _department, _typeOfEmployee, _SSN)
        {
            this.hoursWorked = hoursWorked;
            this.HourlyRate = hourlyRate;
        }
        public void addHours(double hours)
        {
            hoursWorked += hours;
        }
        public override double Pay()
        {
            return hourlyRate * hoursWorked;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nHourly Rate : {HourlyRate}\nHours Worked : {HoursWorked}";
        }
        public override string Print()
        {
            return ToString();
        }
    }
}
