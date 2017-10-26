using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_ObjectsChallengesAnswers
{
    class Netflix2
    {
        //Bronze - Properties 
        public string Name { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }

        //Silver - Methods 
        //curly braces define the scope of the function (what is run)
        public void GetSuggestion()
        {
           // Console.WriteLine("The show's name is " + this.Name); returns all of the values of name
            if(this.Rating > 3.5)
            {
                Console.WriteLine("This is a pretty good show.");
            }
            else
            {
                Console.WriteLine("Don't waste your time!");
            }
        }


    }
}
