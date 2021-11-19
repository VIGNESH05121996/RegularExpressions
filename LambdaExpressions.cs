using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    public class LambdaExpressions
    {
        //public string message;
        //public LambdaExpressions(string message) //initilizing Constructor
        //{
        //    this.message = message;
        //}

        public void FirstName()
        {
            List<string> name = new List<string>();
            Console.WriteLine("\nEnter First Name");
            string firstName = Console.ReadLine();
            name.Add(firstName);
            string firstNameExpression = "^[A-Z]{1}[a-zA-Z]{2,}"; //Regular Expression shows that firstName starts with caps and minimum of 3 character
            string result = name.Find(x=>Regex.IsMatch(firstName,firstNameExpression)); //lambda expression using regular expression
            if(result != null)
            {
                Console.WriteLine(firstName+" is valid first name");
            }
            else
            {
                Console.WriteLine(firstName+" is invalid first name");
            }
        }

        public void LastName()
        {
            List<string> name = new List<string>();
            Console.WriteLine("\nEnter Last Name");
            string lastName = Console.ReadLine();
            name.Add(lastName);
            string lastNameExpression = "^[A-Z]{1}[a-zA-Z]{2,}"; //Regular Expression shows that lastName starts with caps and minimum of 3 character
            string result = name.Find(x => Regex.IsMatch(lastName, lastNameExpression)); //lambda expression using regular expression
            if (result != null)
            {
                Console.WriteLine(lastName + " is valid last name");
            }
            else
            {
                Console.WriteLine(lastName + " is invalid last name");
            }
        }

        public void ValidEmail()
        {
            List<string> email = new List<string>();
            Console.WriteLine("\nEnter Email");
            string mail = Console.ReadLine();
            email.Add(mail);
            string emailExpression = @"^[a-zA-Z0-9]+[+-._]?[a-zA-Z0-9]*[+-._]?[a-zA-Z0-9]+@[a-zA-Z0-9]+[.]{1}[a-zA-Z]{2,3}[.]?[a-zA-Z]{0,3}$"; //Regular Expression shows to test all valid email
            string result = email.Find(x => Regex.IsMatch(mail, emailExpression)); //lambda expression using regular expression
            if (result != null)
            {
                Console.WriteLine(mail + " is valid email");
            }
            else
            {
                Console.WriteLine(mail + " is invalid email");
            }
        }

        public void ValidMobile()
        {
            List<string> mobile = new List<string>();
            Console.WriteLine("\nEnter Mobile Number");
            string number = Console.ReadLine();
            mobile.Add(number);
            string numberExpression = "^([0-9]{2}[ ][0-9]{10})|([0-9]{3}[ ][0-9]{10})$"; //Regular Expression shows that number should contain country code followed by space and 10 digit number
            string result = mobile.Find(x => Regex.IsMatch(number, numberExpression)); //lambda expression using regular expression
            if (result != null)
            {
                Console.WriteLine(number + " is valid mobile number");
            }
            else
            {
                Console.WriteLine(number + " is invalid mobile number");
            }
        }

        public void ValidPassword()
        {
            List<string> password = new List<string>();
            Console.WriteLine("\nEnter Password");
            string word = Console.ReadLine();
            password.Add(word);
            string passwordExpression = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^a-zA-Z0-9]).{8,}$"; //Regular Expression shows that to pass all password rule
            string result = password.Find(x => Regex.IsMatch(word, passwordExpression)); //lambda expression using regular expression
            if (result != null)
            {
                Console.WriteLine(word + " is valid password");
            }
            else
            {
                Console.WriteLine(word + " is invalid password");
            }
        }
    }
}
