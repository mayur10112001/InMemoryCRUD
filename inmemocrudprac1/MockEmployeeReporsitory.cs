using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inmemocrudprac1
{
   public class MockEmployeeRepository : IEmployeeRepository
    {
        public static List<Employee> empList;
        public MockEmployeeRepository()
        {
            empList = new List<Employee>()
            {
                new Employee(){ Id=1, Name="Ram", Department=Dept.MKT, Email="ram_mkt@gmail.com" },
                new Employee(){ Id=2, Name="Abhi", Department=Dept.HR, Email="abhi_hr@gmail.com"},
                new Employee(){ Id=3, Name="Divya", Department=Dept.ADV,Email="divya_adv@gmail.com"}
            };
        }
        public Employee Add(Employee employee)
        {
            employee.Id = empList.Max(e => e.Id)+1;
            empList.Add(employee);
            return employee;
        }
        public Employee Delete(int Id)
        {
            Employee employee = empList.FirstOrDefault(e => e.Id == Id);
            if(employee!=null)
            {
                empList.Remove(employee);
            }
            return employee;
        }

        public IEnumerable<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return empList;
        }

        public Employee GetEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public Employee Update(Employee employeeChanges)
        {
            Employee employee = empList.FirstOrDefault(e => e.Id == employeeChanges.Id);
            if(employee!=null)
            {
                employee.Id = employeeChanges.Id;
                employee.Name = employeeChanges.Name;
                employee.Department = employeeChanges.Department;
            }
            return employee;
        }
        
    }
    
}
