namespace Employee_Management_Application
{
    internal class Department
    {
        private int idDepartment;
        private string nameDepartment = string.Empty;

        public int IdDepartment
        {
            get { return idDepartment; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Id must be greater than 0");
                }
                else
                {
                    idDepartment = value;
                }

            }

        }

        public string NameDepartment
        {
            get
            {
                return nameDepartment;
            }
            set
            {
                if (value == null || value.Length == 0)
                {
                    Console.WriteLine("Name cannot be null or empty");
                }
                else
                {
                    nameDepartment = value;
                }
            }
        }

        public Department()
        {
            idDepartment = 0;
            nameDepartment = "Unknown";
        }
        public Department(int _idDepartment, string _nameDepartment)
        {
            IdDepartment = _idDepartment;
            NameDepartment = _nameDepartment;
        }

        public override string ToString()
        {
            return $"Department Name : {nameDepartment}\nDepartment Id : {idDepartment}";
        }
        public void Print()
        {
            Console.WriteLine(ToString());
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Department))
            {
                return false;
            }
            Department other = obj as Department;
            return this.idDepartment == other.idDepartment && this.nameDepartment == other.nameDepartment;


        }

        public override int GetHashCode()
        {
            int prime = 7;
            int result = 1;
            result = prime * result + idDepartment;
            result = prime * result + nameDepartment.GetHashCode();
            return result;
        }
     
        
    }
}
