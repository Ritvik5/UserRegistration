using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class ValidatePattern
    {
        string data;
        public ValidatePattern(string data)
        {
            this.data = data; 
        }

        public string ValidFirstName()
        {
            string namePattern = "^[A-Z]{1}[A-Za-z]{3,}$";
            Regex regexObj = new Regex(namePattern);
            if (regexObj.IsMatch(this.data))
            {
                Console.WriteLine("\nEntered input is correct!");
                return this.data;
            }
            else
            {
                Console.WriteLine("\nEntered Input is incorrect!");
                return "Invalid";
            }
        }
    }
}
