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

        public void LastName()
        {
            string lastName = "^[A-Z]{1}[a-zA-Z]{2,}$";
            Console.WriteLine("Enter Last Name:");
            string name = Convert.ToString(Console.ReadLine());
            Regex regex = new Regex(lastName);
            if (regex.IsMatch(name))
            {
                Console.WriteLine(name + " is valid");
            }
            else
            {
                Console.WriteLine("Invalid name(Last Name should be in capital)-Please Check Your Name");
            }
        }

        public void ValidEmail()
        {
            string email = @"^[a-zA-Z0-9]+[+-._]?[a-zA-Z0-9]*[+-._]?[a-zA-Z0-9]+@[a-zA-Z0-9]+[.]{1}[a-zA-Z]{2,3}[.]?[a-zA-Z]{0,3}$";
            Console.WriteLine("Enter Email:");
            string mail = Convert.ToString(Console.ReadLine());
            Regex regex = new Regex(email);
            if (regex.IsMatch(mail))
            {
                Console.WriteLine(mail + " is valid");
            }
            else
            {
                Console.WriteLine("Invalid email-Please Check Your email");
            }
        }

        public void MobileNumber()
        {
            string mobile = "^([0-9]{2}[ ][0-9]{10})|([0-9]{3}[ ][0-9]{10})$";
            Console.WriteLine("Enter Mobile Number:");
            string number = Convert.ToString(Console.ReadLine());
            Regex regex = new Regex(mobile);
            if (regex.IsMatch(number))
            {
                Console.WriteLine(number + " is valid");
            }
            else
            {
                Console.WriteLine("Invalid email-Please Check Your email");
            }
        }
    }
}
