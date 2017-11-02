using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_TryCatch
{
    class Employee
    {
        static void ProcessString(string s)
        {
            if (s == null)
            {
                throw new ArgumentNullException();
            }
        }

        static void Main()
        {
            try
            {
                string s = null;
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
        //public int ID { get; set; }
        //public string Name { get; set; }

        //"Backing" Fields
        private int _id;
        private string _name;
        private string _workQuote;

        //Properties
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                if (value < 0)
                    throw new Exception("The Employee ID is invalid.");
                _id = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new Exception("The Employee Name is invalid.");
                _name = value.Trim();
            }
        }

        //Method
        public void SetWorkQuote(string quote)
        {
            this._workQuote = quote;
        }

        public string GetQuote()
        {
            return this._workQuote;
        }

    }
}
