﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Override
{
    class Triangle : Shape
    {
        //Constructor
        public Triangle(int radius)
        {
            this.Radius = radius;
        }

        //Properties
        public int Radius { get; set; }
        public int Base { get; set; }
        public int Height { get; set; }

        //Methods
        public override double Area()
        {
            return (Base * Height) / 2;
        }
    }
}
