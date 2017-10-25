using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Donut PaulsDonut = new Donut();
            Donut KennDonut = new Donut();
            Donut TomsDonut = new Donut();

            TomsDonut.Filling = "Boston Creme";
            TomsDonut.Price = 2.50M;
            TomsDonut.Type = "Filled";
            TomsDonut.IsSpecial = true;

            KennDonut.Filling = "Strawberry jelly";
            KennDonut.Price = 0;
            KennDonut.Type = "Jelly";
            KennDonut.IsSpecial = false;


            PaulsDonut.Filling = "Cherry Jelly";
            PaulsDonut.Price = 7.99M;
            PaulsDonut.Type = "Jelly";
            PaulsDonut.IsSpecial = true;

            Console.WriteLine(PaulsDonut);
            Console.WriteLine(PaulsDonut.Filling);
        }
    }
}
