﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_ConstructorChallenge
{
    class MobilePhone
    {
        //Constructor bronze
        public MobilePhone(string make, string model)
        {
            this.Make = make;
            this.Model = model;
        }

        //Properties
        public string Make { get; set; }
        public string Model { get; set; }

        //Methods
        public void PrintPhone()
        {
            Console.WriteLine($"I own a {this.Make} {this.Model}");
        }
    }
}
