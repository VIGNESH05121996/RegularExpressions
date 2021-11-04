using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace RegularExpressions
{
    class UserRegistration
    {
        public void FirstName()
        {
            string firstName = "^[A-Z]{1}[a-zA-Z]{2,}";
            Console.WriteLine("Enter First Name:");
            string name = Convert.ToString(Console.ReadLine());
            Regex regex = new Regex(firstName);
            if (regex.IsMatch(name))
            {
                Console.WriteLine(name + " is valid");
            }
            else
            {
                Console.WriteLine("Invalid name(First Name should be in capital)-Please Check Your Name");
            }
        }
    }
}
