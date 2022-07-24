using System.Collections.Generic;
using System.Linq;

namespace CharpFundamentals.Collections
{
    public class Employee
    {   
        public Employee(int sno, string name, int age)
        {
            Sno = sno;
            Name = name;
            Age = age;
        }

        public int Sno { get; }

        public string Name { get; }

        public int Age { get; }

    }

    public class Manager
    {
        public string Name { get; set; }
    }

    public class EmployeeFactory
    {
        public EmployeeFactory()
        {
            Employees = new List<Employee>()
            {
                new Employee(1, "Raja", 24),
                new Employee(2, "Kumar", 20),
                new Employee(3, "Vijay", 24),
                new Employee(4, "Vishnu", 24),
                new Employee(5, "Vikram", 24),
                new Employee(6, "Vinay", 20)
            };
        }

        public List<Employee> Employees { get; }
    }


    public class LinqTest
    {
        EmployeeFactory _employeeFactory;
        public LinqTest()
        {
            _employeeFactory = new EmployeeFactory();
        }
        public IEnumerable<Employee> GetEmployeesOfAge20()
        {
            List<Employee> employees = _employeeFactory.Employees;

            IEnumerable<Employee> employees1 = from employee in employees where employee.Age == 20 select employee;

            IEnumerable<Manager> managers_linq = from employee in employees where employee.Age == 20 select new Manager() { Name = employee.Name };

            IEnumerable<Manager> managers = employees.Where(employee => employee.Age == 20).Select(employee => new Manager() {Name = employee.Name });

            return employees.Where(employee => employee.Age == 20);
        }

        private bool isAge20(Employee employee)
        {
            return employee.Age == 20;
        }
    }
}
