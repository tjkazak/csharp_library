using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._15_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an array of instructors
            string[] instructors = { "Jay", "Paul", "Kenn", "Dave", "Auri" };

            //Set up the query
            IEnumerable<string> query = from i in instructors
                                        where i.Length == 4
                                        select i;

            //Loop through the array using the query
            foreach (string name in query)
            {
                Console.WriteLine(name);

            }

            //Example 2 - A list of objects
            IEnumerable<Employee> employees = new List<Employee>()
            {
                //Objects
                new Employee {ID=1, Name = "Tommy", HireDate=new DateTime(1976,1,5)},
                new Employee {ID=2, Name = "Layla", HireDate=new DateTime(2016,10,20)},
                new Employee {ID=3, Name = "Karen", HireDate=new DateTime(2016,8,18)},
                new Employee {ID=4, Name = "Jaxson", HireDate=new DateTime(2011,11,6)}

            };

            //Set up the query
            IEnumerable<Employee> queryTwo = from e in employees
                                           where e.HireDate.Year == 2016
                                           orderby e.Name ascending
                                           select e;

            //Loop through the array using the query
            foreach (Employee employee in queryTwo)
            {
                //Interpolation being used to write out all values within the List
                Console.WriteLine($"{employee.Name} {employee.ID} {employee.HireDate}");
                //writing out individual list vars
                Console.WriteLine(employee.Name);
                Console.WriteLine(employee.ID);
                //This only writes out the first call
                Console.WriteLine(employee.Name, employee.ID, employee.HireDate);

            }


        }
    }
}
