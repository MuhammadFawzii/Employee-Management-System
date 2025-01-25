using Employee_Management_Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System
{
    internal class DepartmentList
    {
        private List<Department> deptList =new List<Department>();
        public void AddDepartment(Department department)
        {
            deptList.Add(department);
        }
        public void RemoveDepartment(Department department)
        {
            deptList.Remove(department);
        }
        public void PrintDepartmentsList()
        {
            if (deptList.Count == 0)
            {
                Console.WriteLine("No Employee");
            }
            else
            {
                for (int i = 0; i < deptList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}]");
                    Console.WriteLine(deptList[i].ToString());
                    Console.WriteLine();

                }
            }
        }
        private void PauseBeforeClear()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
        }
        public void DepartmentMenu()
        {
            int choice;
            do
            {
                Console.Clear(); // Clear the screen at the start of each menu display for a clean interface.
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Select Function Number :");
                Console.WriteLine("1. Add New Department");
                Console.WriteLine("2. Print Department Details");
                Console.WriteLine("3. Exiting ");
                Department newDepartment = new Department();
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:

                        EnterDepartmentDetails();
                        PauseBeforeClear();
                        break;
                    case 2:
                        PrintDepartmentsList();
                        PauseBeforeClear();
                        break;
                    case 3:
                        Console.WriteLine("Exiting .....");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            } while (choice != 3);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void EnterDepartmentDetails()
        {
            Department newDepartment = new Department();
            Console.WriteLine("Enter department details:");
            Console.Write($"-> Enter Department Id:");
            newDepartment.IdDepartment = Convert.ToInt32(Console.ReadLine());
            Console.Write($"-> Enter Department Name:");
            newDepartment.NameDepartment = Console.ReadLine();
            AddDepartment(newDepartment);
        }




    }
}
