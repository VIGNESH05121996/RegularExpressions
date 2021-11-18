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
            string firstName = "^[A-Z]{1}[a-zA-Z]{2,}"; //Regular Expression shows that firstName starts with caps and minimum of 3 character
            string[] name = { "Vig", "vig", "Vignesh", "VIg", "Vig" }; //set of names to be validated
            Regex regex = new Regex(firstName); //calling Regex function
            foreach(string word in name)
            {
                if (regex.IsMatch(word))
                {
                    Console.WriteLine(word + " is valid");
                }
                else
                {
                    Console.WriteLine("Invalid name(First Name should be in capital)-Please Check Your Name");
                }
            }
        }

        public void LastName()
        {
            string lastName = "^[A-Z]{1}[a-zA-Z]{2,}$"; //Regular Expression shows that lastName starts with caps and minimum of 3 character
            Console.WriteLine("Enter Last Name:");
            string[] name = { "Mut", "mut", "Muthu", "MUt", "Mut" }; //set of last name to be validated
            Regex regex = new Regex(lastName); //calling Regex function
            foreach(string word in name)
            {
                if (regex.IsMatch(word))
                {
                    Console.WriteLine(word + " is valid");
                }
                else
                {
                    Console.WriteLine("Invalid name(Last Name should be in capital)-Please Check Your Name");
                }
            }
        }

        public void ValidEmail()
        {
            string email = "^[a-z]{3}[.][a-z]*[@]{1}[bl]{2}[.]{1}[co]{2}[.]{1}[a-z]*$"; //Regular Expression shows Email should have 3 mandatory parts(abc,bl &co) and 2 optional(xyz & in) with precise @ and . position
            string[] mail = { "abc.xyz@bl.co.in", "abc@bl.co.in", "abc.x@gm.co.in", "abc.xyzbl.co.in", "abc,xyz@bl.in", "ab.xyz@bl.co.in", "abc.nxcst@bl.co.in" }; //set of emayl to be validated
            Regex regex = new Regex(email); //calling Regex function
            foreach(string set in mail)
            {
                if (regex.IsMatch(set))
                {
                    Console.WriteLine(set + " is valid");
                }
                else
                {
                    Console.WriteLine("Invalid email-Please Check Your email");
                }
            }
        }

        public void MobileNumber()
        {
            string mobile = "^([0-9]{2}[ ][0-9]{10})|([0-9]{3}[ ][0-9]{10})$"; //Regular Expression shows that number should contain country code followed by space and 10 digit number
            string[] number = { "91 7656511056", "01 7486631255", "715682331652", "91 75866328", "91 0123456789", "91 768697195312" }; //set of mobile numbers to be validated
            Regex regex = new Regex(mobile); //calling Regex function
            foreach(string phno in number )
            {
                if (regex.IsMatch(phno))
                {
                    Console.WriteLine(phno + " is valid");
                }
                else
                {
                    Console.WriteLine("Invalid Mobile Number-Please Check Your email");
                }
            }
        }

        public void ValidPasswordRule1()
        {
            string password = "^[a-zA-Z0-9]{8,}$"; //Regular expression shows that password should contain minimum 8 characters
            string[] pass = { "mvignesh", "mvig", "Mvignesh", "mvignesh0512", "0512mvig" }; //set of passwords to be validated
            Regex regex = new Regex(password); //calling Regex function
            foreach(string set in pass)
            {
                if (regex.IsMatch(set))
                {
                    Console.WriteLine(set + " is valid");
                }
                else
                {
                    Console.WriteLine("Invalid password-Please Check Your password");
                }
            }
        }

        public void ValidPasswordRule2()
        {
            string password = "^[a-zA-Z0-9]{8,}$"; //Regular expression shows that password should have atleast 1 upper case
            string[] pass = { "V1ignesh", "Vignesh1", "Vigne4sh", "Vignesh1", "Mvignesh", "mvigNesg1", "mvignesh05" }; //set of passwords to be validated
            Regex regex = new Regex(password); //calling Regex function
            foreach (string set in pass)
            {
                if (regex.IsMatch(set))
                {
                    Console.WriteLine(set + " is valid");
                }
                else
                {
                    Console.WriteLine("Invalid password-Please Check Your password");
                }
            }
        }

        public void ValidPasswordRule3()
        {
            string password = "^(?=.*[0-9])(?=.*[A-Z])[a-zA-Z0-9]{8}$"; //Regular expression shows that should have atleast 1 numeric number in the password
            string[] pass = { "V1ignesh", "Vignesh1", "Vigne4sh", "Vignesh1", "Mvignesh", "mvigNeshg1", "mvignesh05" };  //set of passwords to be validated
            Regex regex = new Regex(password); //calling Regex function
            foreach (string set in pass)
            {
                if (regex.IsMatch(set))
                {
                    Console.WriteLine(set + " is valid");
                }
                else
                {
                    Console.WriteLine("Invalid password-Please Check Your password");
                }
            }
        }

        public void ValidPasswordRule4()
        {
            string password = "^(?=.*[0-9])(?=.*[A-Z])(?=.*[!@#$%^&*])[a-zA-Z0-9!@#$%^&*]{8,}$"; //Regular expression shows that has exactly one special case
            string[] pass = { "V1igne@sh", "Vignesh&2", "Vigne%5sh", "Mvig!nesh", "Mvig@nesh1", "mvignesh!" }; //set of passwords to be validated
            Regex regex = new Regex(password); //calling Regex function
            foreach (string set in pass)
            {
                if (regex.IsMatch(set))
                {
                    Console.WriteLine(set + " is valid");
                }
                else
                {
                    Console.WriteLine("Invalid password-Please Check Your password");
                }
            }
        }

        public void AllValidEmails()
        {
            string email = @"^[a-zA-Z0-9]+[+-._]?[a-zA-Z0-9]*[+-._]?[a-zA-Z0-9]+@[a-zA-Z0-9]+[.]{1}[a-zA-Z]{2,3}[.]?[a-zA-Z]{0,3}$"; //Regular Expression shows to test all valid email
            string[] mail = { "1.abc@yahoo.com", "2.abc-100@yahoo.com", "3.abc.100@yahoo.com", "2.abc111@abc.com", "4.abc-100@abc.net", "5.abc.100@abc.com.au", "6.abc@1.com", "7.abc@gmail.com.com", "8.abc+100@gmail.com" }; //set of emayl to be validated
            Regex regex = new Regex(email); //calling Regex function
            foreach (string set in mail)
            {
                if (regex.IsMatch(set))
                {
                    Console.WriteLine(set + " is valid");
                }
                else
                {
                    Console.WriteLine("Invalid email-Please Check Your email");
                }
            }
        }
    }
}
