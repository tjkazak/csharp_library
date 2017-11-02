using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_TryCatchNew
{
    class Program
    {
        static void ProcessString(string s)
        {
            if (s == null)
            {
                throw new ArgumentNullException();
            }
            throw new Exception();
        }

        static void Main(string[] args)
        {
            try
            {
                string s = "Tom";
                ProcessString(s);
            }
            // Most specific: 
            catch (ArgumentNullException e)
            {
                Console.WriteLine("{0} First exception caught.", e);
            }
            // Least specific: 
            catch (Exception e)
            {
                Console.WriteLine("{0} Second exception caught.", e);
            }

        }
    }
}
