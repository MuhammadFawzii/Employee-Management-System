using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_Application
{
    internal class Project
    {
        private int id;
        private string name;
        private StaffMember manager;
        private double currentCost;
        private List<Budget> budgetList=new List<Budget>();

        public Project()
        {
            this.id = 0;
            this.name = string.Empty;
        }
        public Project(int id, string name, StaffMember manager)
        {
            this.Id = id;
            this.Name = name;
            this.Manager = manager;
        }

        public int Id 
        { 
            get=>id; 
            set { if (value > 0) 
                    id = value;
                  else
                    Console.WriteLine("Invalid Project Id");
                 }
        }
        public string Name 
        { 
            get=> name;
            set
            {
                if (value != null) name = value;
                else Console.WriteLine("Enter Project Name");
            } 
        }

        public StaffMember Manager { get => manager; private set => manager = value; }
        public double CurrentCost { get => currentCost; private set => currentCost = value; }
        public List<Budget> BudgetList { get => budgetList;private set => budgetList = value; }

        public void AddBudget(Budget value)
        {
            budgetList.Add(value);

        }
        public double GetTotalBudget()
        {
            double total = 0;
            foreach (var item in budgetList)
            {

                total += item.Value;
            }
            return total;

        }
        public Budget GetBudgetById(int id)
        {
            Budget budget = budgetList.Find(x => x.Id == id);
            if(budget == null)
            {
                throw new Exception("Invalid Budget");
            }
            return budget;
        }

        public override string ToString()
        {
            return $"Project Id: {id} | Project Name:{name} | Project Manager :{manager} " +
                $"| Current Cost: {currentCost} | Total Budget: {GetTotalBudget()} ";
        }
        public void Print()
        {
            Console.WriteLine(ToString());
        }
        public override bool Equals(object? obj)
        {
            if(obj != null && obj.GetType() == typeof(Project))
            {
                Project p1 = (Project)obj;
                return this.id.Equals(p1.Id);
            }
            else
                return false;
        }

     


    }
}
