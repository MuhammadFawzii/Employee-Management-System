namespace Employee_Management_Application
{
    internal class Volunteer : StaffMember
    {
        private double amount;
        public double Amount
        {
            get { return amount; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Amount must be a positive number", nameof(Amount));
                amount = value;
            }
        }
        public Volunteer(int _id, string _name, string _phone, string _email, double _amount, Department _department, TypeOfEmployee typeOfEmployee) : base(_id, _name, _phone, _email,_department,typeOfEmployee)
        {
            this.Amount = _amount;
        }
        public override string ToString()
        {
            return $"Volunteer Name : {Name}\nVolunteer Id : {Id}\nVolunteer Phone : {Phone}\nVolunteer Email : {Email}\nVolunteer Amount : {Amount}";
        }
        public override string Print()
        {
            return ToString();
        }

        public override double Pay()
        {
            return amount;
        }

       
    }
}
