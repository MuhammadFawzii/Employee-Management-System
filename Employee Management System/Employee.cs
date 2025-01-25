namespace Employee_Management_Application
{
    internal class Employee : StaffMember
    {
        protected string ssn;
        public string SSN
        {
            get { return ssn; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length != 9 || !value.All(char.IsDigit))
                    throw new ArgumentException("SSN must be 9 digits and contain only digits", nameof(SSN));
                ssn = value;
            }
        }

        public Employee(int _id, string _name, string _phone, string _email, Department _department, TypeOfEmployee _typeOfEmployee, string _SSN) : base(_id, _name, _phone, _email, _department, _typeOfEmployee)
        {
            this.SSN = _SSN;
        }
        public Employee() : base()
        {
        }
        public override double Pay()
        {
            return 0.0;
        }
        public override string ToString()
        {
            return $"\nName : {Name}\nId : {Id}\nPhone : {Phone}\nEmail : {Email}\nSSN : {SSN}";
        }
        public override string Print()
        {
            return ToString();
        }
       

        //public override Employee TakeStaffMemberDetails()
        //{
        //    Console.WriteLine("Enter the Staff Member Id");
        //    int id = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter the Staff Member Name");
        //    string name = Console.ReadLine();
        //    Console.WriteLine("Enter the Staff Member Phone");
        //    string phone = Console.ReadLine();
        //    Console.WriteLine("Enter the Staff Member Email");
        //    string email = Console.ReadLine();
        //    Console.WriteLine("Enter the Staff Member Department Details:");
        //    Console.WriteLine("Enter the Department Id");
        //    int deptId = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter the Department Name");
        //    string deptName = Console.ReadLine();
        //    Department dept = new Department(deptId, deptName);
        //    Console.WriteLine("Enter the Staff Member Type");
        //    TypeOfEmployee type = (TypeOfEmployee)Enum.Parse(typeof(TypeOfEmployee), Console.ReadLine());
        //    Console.WriteLine("Enter the Staff Member SSN");
        //    string ssn = Console.ReadLine();
        //    Employee member = null;

        //    if (type == TypeOfEmployee.Salaried)
        //    {
        //        Console.WriteLine("Enter the Staff Member Salary");
        //        double salary = Convert.ToDouble(Console.ReadLine());
        //        Console.WriteLine("1) Normal Salary");
        //        Console.WriteLine("2) Executive Salary");
        //        Console.WriteLine("3) Exit");
        //        int choice = Convert.ToInt32(Console.ReadLine());
        //        switch (choice)
        //        {
        //            case 1:
        //                member = new Salaried_Employee(id, name, phone, email, dept, type, ssn, salary);
        //                break;
        //            case 2:
        //                Console.WriteLine("Enter the Staff Member Bonus");
        //                double bonus = Convert.ToDouble(Console.ReadLine());
        //                member = new Executive_Employee(id, name, phone, email, dept, type, ssn, salary, bonus);
        //                break;
        //            case 3:
        //                Console.WriteLine("Exiting...");
        //                break;
        //            default:
        //                Console.WriteLine("Invalid Choice");
        //                break;
        //        }

        //    }
        //    else if (type == TypeOfEmployee.Hourly)
        //    {
        //        Console.WriteLine("Enter the Staff Member Hourly Rate");
        //        double hourlyRate = Convert.ToDouble(Console.ReadLine());
        //        Console.WriteLine("Enter the Staff Member Hours Worked");
        //        double hoursWorked = Convert.ToDouble(Console.ReadLine());
        //        member = new Hourly_Employee(id, name, phone, email, dept, type, ssn, hoursWorked, hourlyRate);

        //    }
        //    else if (type == TypeOfEmployee.Commission)
        //    {
        //        Console.WriteLine("Enter the Staff Member Target Commission");
        //        double targetCommissionRate = Convert.ToDouble(Console.ReadLine());
        //        member = new Commission_Employee(id, name, phone, email, dept, type, ssn, targetCommissionRate);

        //    }
        //    return member;

        //}

    }
}
