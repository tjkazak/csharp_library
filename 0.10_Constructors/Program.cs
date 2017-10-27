using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student tomStudent = new Student();
            //tomStudent.FirstName = "Tom";
            //tomStudent.LastName = "Kazak";
            //tomStudent.Age = 41;
            //tomStudent.Grade = 13;

            Student tomStudent = new Student("Tom", "Kazak", 41, 13);
            Student jayStudent = new Student("Jay","Jackson", 41);
            Student jaxStudent = new Student("Jax");

        }
    }
}
