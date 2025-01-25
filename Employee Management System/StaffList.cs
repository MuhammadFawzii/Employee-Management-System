using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace Employee_Management_Application
{
    internal class StaffList
    {
        private List<StaffMember> staffList = new List<StaffMember>();
        //Constructor
        
        public StaffList()
        {
            staffList = new List<StaffMember>();
        }
        public int CountMembers()
        {
            return staffList.Count;
        }


        //Methods
        public void AddMember(StaffMember staffMember)
        {
            staffList.Add(staffMember);
        }
        public void DeleteMember(StaffMember staffMember)
        {
            staffList.Remove(staffMember);

        }
        public bool ValidMember(StaffMember staffMember)
        {
            return staffList.Contains(staffMember);
        }

        public StaffMember GetMemberById(int id)
        {
            StaffMember staffMember = staffList.Find(x => x.Id == id);
            if (staffMember == null)
            {
                throw new Exception("Staff member not found with the given ID.");

            }
            return staffMember;
        }
        public StaffMember GetLastMember()
        {
            return staffList[staffList.Count - 1];
        }

        public int GetIndexMember(StaffMember staffMember)
        {
            return staffList.IndexOf(staffMember);
        }
        public void UpdateMember(StaffMember oldStff, StaffMember newStaff)
        {
            staffList[GetIndexMember(oldStff)] = newStaff;
        }

        //---------------M.a--------------//
        public StaffMember Search(Func<StaffMember, bool> predicate)
        {
            foreach (var item in staffList)
            {
                if (predicate(item))
                    return item;
            }
            return null;
        }


        public void ShowAllMembers()
        {
            if (staffList.Count == 0)
            {
                Console.WriteLine("No Employee");
            }
            else
            {
                for (int i = 0; i < staffList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}]");
                    Console.WriteLine(staffList[i].Print());
                    Console.WriteLine();

                }
            }
           
           
        }
        public void CalculatePayroll()
        {
            double totalPayroll = 0.0;
            foreach (var staffMember in staffList)
            {
                totalPayroll += staffMember.Pay();
            }
            Console.WriteLine($"Total Payroll: {totalPayroll}");
        }
        private void PauseBeforeClear()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor= ConsoleColor.DarkYellow;
        }
        public void StaffMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine();
            int choice ;
            do
            {
                Console.Clear(); // Clear the screen at the start of each menu display for a clean interface.
                Console.WriteLine("1. Add New Member");
                Console.WriteLine("2. Print All Members");
                Console.WriteLine("3. Calculate Payroll");
                Console.WriteLine("4. Delete Member");
                Console.WriteLine("5. Exit");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Member Details:");
                        TakeEmployeeDetails();
                        PauseBeforeClear(); // Allow the user to see the result before clearing.
                        break;
                    case 2:
                        ShowAllMembers();
                        PauseBeforeClear();
                        break;
                    case 3:
                        CalculatePayroll();
                        PauseBeforeClear();
                        break;
                    case 4:
                        Console.WriteLine("Enter member id for deleting");
                        int id=int.Parse(Console.ReadLine());
                        DeleteMember(GetMemberById(id));
                        Console.WriteLine("Deleting is Done");
                        PauseBeforeClear();
                        break;
                    case 5:
                        break;
                   
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            } while (choice != 5);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

        }


        public void TakeEmployeeDetails()
        {
            Console.Write("-> Enter Id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("-> Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("-> Enter Phone: ");
            string phone = Console.ReadLine();
            Console.Write("-> Enter Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("-> Enter Department Details:");
            Console.Write("\t=> Enter Id: ");
            int deptId = Convert.ToInt32(Console.ReadLine());
            Console.Write("\t=> Enter Name: ");
            string deptName = Console.ReadLine();
            Department dept = new Department(deptId, deptName);
            Console.Write("-> Enter Type: ");
            TypeOfEmployee type = (TypeOfEmployee)Enum.Parse(typeof(TypeOfEmployee), Console.ReadLine());
            Console.Write("-> Enter SSN: ");
            string ssn = Console.ReadLine();
            Employee selectedEmployee = GetObjectEmployeeTypes(id, name, phone, email, dept, type, ssn);
            AddMember(selectedEmployee);
        }
        public Employee GetObjectEmployeeTypes(int id, string name, string phone, string email, Department department, TypeOfEmployee typeOfEmployee, string SSN)
        {
            Employee member=null ;
            if (typeOfEmployee == TypeOfEmployee.Salaried)
            {
                Console.Write("-> Enter Salary: ");
                double salary = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("\t1] Normal Salary");
                Console.WriteLine("\t2] Executive Salary");
                Console.WriteLine("\t3] Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        member = new Salaried_Employee(id, name, phone, email, department, typeOfEmployee, SSN, salary);
                        break;
                    case 2:
                        Console.Write("-> Enter Bonus: ");
                        double bonus = Convert.ToDouble(Console.ReadLine());
                        member = new Executive_Employee(id, name, phone, email, department, typeOfEmployee, SSN, salary, bonus);
                        break;
                    case 3:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            }
            else if (typeOfEmployee == TypeOfEmployee.Hourly)
            {
                Console.Write("-> Enter Hourly Rate: ");
                double hourlyRate = Convert.ToDouble(Console.ReadLine());
                Console.Write("-> Enter Hours Worked: ");
                double hoursWorked = Convert.ToDouble(Console.ReadLine());
                member = new Hourly_Employee(id, name, phone, email, department, typeOfEmployee, SSN, hoursWorked, hourlyRate);

            }
            else if (typeOfEmployee == TypeOfEmployee.Commission)
            {
                Console.WriteLine("-> Enter Target Commission: ");
                double targetCommissionRate = Convert.ToDouble(Console.ReadLine());
                member = new Commission_Employee(id, name, phone, email, department, typeOfEmployee, SSN, targetCommissionRate);
            }
            return member;
        }

    }
}