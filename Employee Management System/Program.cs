using Employee_Management_Application;
namespace Employee_Management_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //var Emp1 = new StaffMember(1, "Alice Smith", "12345678901", "alice@example.com");
                //var Emp2 = new StaffMember(2, "Bob Johnson", "23456789012", "bob@example.com");
                //var Emp3 = new StaffMember(3, "Charlie Brown", "34567890123", "charlie@example.com");
                //var Emp4 = new StaffMember(4, "Diana Prince", "45678901234", "diana@example.com");
                //var Emp5 = new StaffMember(5, "Ethan Hunt", "56789012345", "ethan@example.com");
                //var Emp6 = new StaffMember(6, "Fiona Gallagher", "67890123456", "fiona@example.com");
                //var Emp7 = new StaffMember(7, "George Bailey", "78901234567", "george@example.com");
                //var Emp8 = new StaffMember(8, "Hannah Montana", "89012345678", "hannah@example.com");
                //var Emp9 = new StaffMember(9, "Isaac Newton", "90123456789", "isaac@example.com");
                //var Emp10 = new StaffMember(10, "Julia Roberts", "01234567890", "julia@example.com");
                //Staff IS = new Staff();
                //IS.AddMember(Emp1);
                //IS.AddMember(Emp2);
                //IS.AddMember(Emp3);
                //IS.AddMember(Emp4);
                //IS.AddMember(Emp5);
                //IS.AddMember(Emp6);
                //IS.DeleteMember(Emp1);
                //IS.UpdateMember(Emp2, new StaffMember(2, "Bob Johnson Updated", "23456789012", "bob@example.com.updated"));
                //IS.ShowallMembers();

                //// Print staff details
                //Emp1.Print();

                //// Check Pay
                //Console.WriteLine($"Payroll: {Emp1.Pay()}");

                SystemRuning.Run();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}