﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._17_Interfaces_ClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayClass exampleArrayClass = new ArrayClass();
            exampleArrayClass.CheckTheCapacity();

            ListClass exampleListClass = new ListClass();
            exampleListClass.CheckTheCapacity();

        }
    }
}
