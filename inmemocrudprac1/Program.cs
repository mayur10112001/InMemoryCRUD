using Microsoft.VisualBasic.FileIO;
using System.ComponentModel.DataAnnotations;

namespace inmemocrudprac1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MockEmployeeRepository db = new MockEmployeeRepository();
            Display(db);
            Employee a = db.Add(new Employee { Name="Kavita",Department=Dept.HR, Email="kavita@gmail.com"});
            Console.WriteLine("Record Added: {0}{1}{2}{3}",a.Id,a.Name,a.Department,a.Email);
            Display(db);
            db.Delete(4);
            Console.WriteLine("Record Deleted: ");
            Display(db);
            Employee m = new Employee { Id = 3, Name = "Sam", Department = Dept.MKT, Email = "sam@CDACtech.com" };
            Console.WriteLine("Record Updated: ");
            UpdateData(m, db);
        }
        static void Display(MockEmployeeRepository db)
        {
            foreach (Employee a in db.GetAllEmployee())
                Console.WriteLine(": {0} {1} {2} {3}", a.Id, a.Name, a.Email, a.Department);
        }
        static void UpdateData(Employee e, MockEmployeeRepository db)
        {
            db.Update(e);
            Display(db);
        }
    }
}