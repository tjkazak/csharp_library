using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_ObjectsChallengesAnswers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bronze - Create 3 Objects - Object Instantiation 
            Netflix2 strangerThings = new Netflix2();
            Netflix2 theOffice = new Netflix2();
            Netflix2 theITCrowd = new Netflix2();

            // Set object values
            theOffice.Name = "The Office";
            theOffice.Genre = "Comedy";
            theOffice.Rating = 5.0;

            strangerThings.Name = "Stranger Things";
            strangerThings.Genre = "Horror";
            strangerThings.Rating = 8.5;

            theITCrowd.Name = "The IT Crowd";
            theITCrowd.Genre = "HaHa";
            theITCrowd.Rating = 2.5;

            Console.WriteLine(theITCrowd.Rating);

            // Silver - Calling the method(GetSuggestion) - uses brackets/parens
            theOffice.GetSuggestion();
            theITCrowd.GetSuggestion();
            strangerThings.GetSuggestion();

            // Gold - Creating a list of Objects
            List<Netflix2> favoriteShows = new List<Netflix2>();

            favoriteShows.Add(theITCrowd);
            favoriteShows.Add(theOffice);
            favoriteShows.Add(strangerThings);

//            foreach (var item in collection) - the item gets created in the loop (anyname you want for the most part)
            foreach (Netflix2 show in favoriteShows)
            {
                Console.WriteLine(show.Name);
                Console.WriteLine(show.Genre);
                Console.WriteLine(show.Rating);
            }
            //           Console.WriteLine(favoriteShows);

            Console.ReadLine();
        }
    }
}
