namespace Employee_Management_Application
{
    public enum TypeOfEmployee
    {
        None,
        Salaried,
        Hourly,
        Executive,
        Commission
    }
    internal abstract class StaffMember
    {
        //Fields

        protected int id;
        protected string name;
        protected string phone;
        protected string email;
        protected Department department;
        private TypeOfEmployee typeOfEmployee;
        //Default Constructor
        public StaffMember()
        {
            id = 0;
            name = string.Empty;
            phone = string.Empty;
            email = string.Empty;
            department = new Department();
            typeOfEmployee = TypeOfEmployee.None;
        }
        // Parameterized Constructor

        public StaffMember(int _id, string _name, string _phone, string _email, Department _department, TypeOfEmployee typeOfEmployee) : this()
        {
            Id = _id;
            Name = _name;
            Phone = _phone;
            Email = _email;
            Department = _department;
            TypeOfEmployee = typeOfEmployee;
        }
        // Properties

        public int Id
        {
            get { return id; }
            private set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Id must be a positive number", nameof(Id));
                id = value;
            }
        }
        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                    throw new ArgumentException("Name must be at least 3 characters long and not null", nameof(Name));
                name = value;
            }
        }
        public string Phone
        {
            get { return phone; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length != 11 || !value.All(char.IsDigit))
                    throw new ArgumentException("Phone number must be 11 digits and contain only digits", nameof(Phone));
                phone = value;
            }
        }
        public string Email
        {
            get { return email; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || !value.Contains("@"))
                    throw new ArgumentException("Email must contain '@' and not be null", nameof(Email));
                email = value;
            }
        }
        public Department Department
        {
            get { return department; }
            set { department = value; }
        }

        protected TypeOfEmployee TypeOfEmployee { get => typeOfEmployee; set => typeOfEmployee = value; }

        // ToString Override

        public override string ToString()
        {
            return $"{this.GetType().Name} Details:\n" +
                $"Id: {this.id}\n" +
                $"Name: {this.name}\n" +
                $"Phone: {this.phone}\n" +
                $"Email: {this.email}\n" +
                $"Department: {this.department}\n" +
                $"Type: {this.typeOfEmployee}";


        }
        public abstract string Print();
        public abstract double Pay();

    }
}
