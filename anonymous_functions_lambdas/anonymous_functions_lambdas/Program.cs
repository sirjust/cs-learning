using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymous_functions_lambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listEmployees = new List<Employee>()
            {
                new Employee{ ID = 101, Name = "Mark"},
                new Employee{ ID = 102, Name = "John"},
                new Employee{ ID = 103, Name = "Mary"},
            };

            // step 2
            //Predicate<Employee> employeePredicate = new Predicate<Employee>(FindEmployee);

            // we want to find the employee with id 102
            // step 3
            Employee employee = listEmployees.Find(delegate(Employee emp) {
                return emp.ID == 102;
            });
            Console.WriteLine("ID = {0}, Name = {1}", employee.ID, employee.Name);
            Console.Read();
        }

        // step 1
        //public static bool FindEmployee(Employee emp)
        //{
        //    return emp.ID == 102;
        //}

        public class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }
    }
}
