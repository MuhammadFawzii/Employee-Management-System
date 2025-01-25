using Employee_Management_Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System
{
    internal class ProjectList
    {
        List<Project> projectsList=new List<Project> ();
        public void AddProject(Project project)
        {
            projectsList.Add(project);
        }
        public void RemoveProject(Project project)
        {
            projectsList.Remove(project);
        }
        public void PrintProjectList()
        {
            foreach (Project project in projectsList)
            {
                project.Print();
            }
        }
        public Project GetProjectById(int id)
        {
            Project project = projectsList.Find(x => x.Id == id);
            if(project == null)
                throw new Exception("Project not found");

            return project;
        }
        public void TakeProjectDetails()
        {
            Console.WriteLine("-> Enter Project details:");
            Console.Write("\t=> Enter Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("\t=> Enter Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("-> Enter Manager details:");

            StaffList staffList = new StaffList(); // Assuming you have a staff list to validate managers
            
            staffList.TakeEmployeeDetails(); // Get manager details.
            StaffMember manager = staffList.GetLastMember();

            Project project = new Project(id, name, manager);
            AddProject(project);
        }
        private void PauseBeforeClear()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
        }

        public void ProjectMenu()
        {
            int choice;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Select Function Number :");
                Console.WriteLine("1. Add New Project");
                Console.WriteLine("2. Print All Projects Details");
                Console.WriteLine("3. Add Budget to Existing Project ");
                Console.WriteLine("4. Increase Budget to Existing Project");
                Console.WriteLine("5. Exit");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {

                    case 1:
                        TakeProjectDetails();
                        PauseBeforeClear();

                        break;
                    case 2:
                        PrintProjectList();
                        PauseBeforeClear();

                        break;
                    case 3:
                        Console.Write("-> Project Id: ");
                        int id = int.Parse(Console.ReadLine());
                        Project project2 = GetProjectById(id);
                        Console.Write("-> Budget Value: ");
                        double valueBudget = double.Parse(Console.ReadLine());
                        int idBudget = project2.BudgetList.Count + 1;
                        project2.AddBudget(new Budget(idBudget, valueBudget));
                        PauseBeforeClear();

                        break;
                    case 4:
                        Console.Write("-> Project Id: ");
                        int idProject = int.Parse(Console.ReadLine());
                        Project project3 = GetProjectById(idProject);
                        Console.Write("-> Budget Id: ");
                        int idBud = int.Parse(Console.ReadLine());
                        Budget budget = project3.GetBudgetById(idBud);
                        Console.Write("-> Budget adds value: ");
                        double increaseValue = double.Parse(Console.ReadLine());
                        budget.increaseBudget(increaseValue);
                        PauseBeforeClear();

                        break;
                    case 5:
                        Console.WriteLine("Exiting....");
                        PauseBeforeClear();

                        break;
                    default:
                        break;
                }
            } while (choice != 5);

            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
