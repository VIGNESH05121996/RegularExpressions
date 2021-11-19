using System;

namespace RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEnter Your Choice--> 1:Userregistration 2:LamdaExpression");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.WriteLine("Welcome To Regular Expressions User Registration");
                    UserRegistration user = new UserRegistration();
                    for (int i = 1; i <= 10; i++)
                    {
                        switch (i)
                        {
                            case 1:
                                user.FirstName();
                                break;

                            case 2:
                                Console.WriteLine("\nValidating Last Name");
                                user.LastName();
                                break;

                            case 3:
                                Console.WriteLine("\nValidating Email");
                                user.ValidEmail();
                                break;

                            case 4:
                                Console.WriteLine("\nValidating Mobile Number");
                                user.MobileNumber();
                                break;

                            case 5:
                                Console.WriteLine("\nValidating Password Rule 1");
                                user.ValidPasswordRule1();
                                break;

                            case 6:
                                Console.WriteLine("\nValidating Password Rule 2");
                                user.ValidPasswordRule2();
                                break;

                            case 7:
                                Console.WriteLine("\nValidating Password Rule 3");
                                user.ValidPasswordRule3();
                                break;

                            case 8:
                                Console.WriteLine("\nValidating Password Rule 4");
                                user.ValidPasswordRule4();
                                break;

                            case 9:
                                Console.WriteLine("\nValidating All Email Rules");
                                user.AllValidEmails();
                                break;

                            default:
                                Console.WriteLine("\nAll Used Cases Are Over");
                                break;
                        }
                    }
                    break;

                case 2:
                    Console.WriteLine("Welcome To Validate User Entry Using Regular Expession using Lambda expression");
                    LambdaExpressions lambda = new LambdaExpressions();
                    for(int i=1;i<=6;i++)
                    {
                        switch(i)
                        {
                            case 1:
                                lambda.FirstName();
                                break;

                            case 2:
                                lambda.LastName();
                                break;

                            case 3:
                                lambda.ValidEmail();
                                break;

                            case 4:
                                lambda.ValidMobile();
                                break;

                            case 5:
                                lambda.ValidPassword();
                                break;

                            default:
                                Console.WriteLine("\nValidated User Entry");
                                break;
                        }
                    }
                    break;

                default:
                    Console.WriteLine("\nEnter a valid input");
                    break;
            }         
        }
    }
}
