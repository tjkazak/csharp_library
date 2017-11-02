using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee newEmployee = new Employee();

            Console.WriteLine("Enter Employee Name: ");
            newEmployee.Name = Console.ReadLine();

            Console.WriteLine("Enter Employee ID: ");
            newEmployee.ID = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"New Employee: {newEmployee.Name}  {newEmployee.ID}.");

            //Set Work Quote
            Console.WriteLine($"Enter a common quote for {newEmployee.Name}.");
            newEmployee.SetWorkQuote(Console.ReadLine());

            //Get Work Quote
            Console.WriteLine(newEmployee.GetQuote());


        }
    }
}
