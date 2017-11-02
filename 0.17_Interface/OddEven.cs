using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._17_Interface
{
    interface IOne
    {
        void ONE(); //Pure Abstract Method Signature  
    }
    interface ITwo
    {
        void TWO();
    }
    interface IThree : IOne
    {
        void THREE();
    }
    interface IFour
    {
        void FOUR();
    }
    interface IFive : IThree
    {
        void FIVE();
    }
    interface IEVEN : ITwo, IFour { }

    class OddEven : IEVEN, IFive //Must Implement all the abstract method, in Derived class
    {
        public void ONE() //Implementation of Abstract Method.  
        {
            Console.WriteLine("This is ONE");
        }
        public void TWO()
        {
            Console.WriteLine("This is TWO");
        }
        public void THREE()
        {
            Console.WriteLine("This is THREE");
        }
        public void FOUR()
        {
            Console.WriteLine("This is FOUR");
        }
        public void FIVE()
        {
            Console.WriteLine("This is FIVE");
        }

    }
}
