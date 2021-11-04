using System;

namespace RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Regular Expressions User Registration");
            UserRegistration user = new UserRegistration();
            user.FirstName();
            user.LastName();
            user.ValidEmail();
            user.MobileNumber();
            user.ValidPasswordRule1();
        }
    }
}
