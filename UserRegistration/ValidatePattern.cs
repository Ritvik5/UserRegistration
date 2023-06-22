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

        public string ValidLastName()
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

        public string ValidEmail()
        {
            string emailPattern = "^[A-Za-z0-9]+([-_.+][A-Za-z0-9]+)?[@][A-Za-z]+[.][A-Za-z]{2,3}([.][a-z]{2})?$";
            Regex regexObj = new Regex(emailPattern);
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
