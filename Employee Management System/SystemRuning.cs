using Employee_Management_System;

namespace Employee_Management_Application
{
    internal class SystemRuning
    {
        public static void Run()
        {
            DepartmentList departmentList = new DepartmentList();
            StaffList staffList = new StaffList();
            ProjectList projectList = new ProjectList();
            while (true)
            {
                int choice;
                Console.WriteLine("Select Menu Number :");
                Console.WriteLine("1. Department Menu");
                Console.WriteLine("2. Staff Menu");
                Console.WriteLine("3. Project Menu");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        departmentList.DepartmentMenu();
                        break;
                    case 2:
                        staffList.StaffMenu();
                        break;
                    case 3:
                        projectList.ProjectMenu();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                }
                Console.Clear();

            }
        }
        private void PauseBeforeClear()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
