using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper.Class;
using Helper.Interface;

namespace Mountly_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Login login = new Login();
            Console.WriteLine("Welcome to Mounthly Expenses Management");
            
            bool flag = true;
            while (flag)
            {
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("+----------------------------------+\r\n" +
                    "|  your Choises                    |\r\n" +
                    "+----------------------------------+\r\n" +
                    "|   1 for user login               |\r\n" +
                    "|   2 for New user registration    |\r\n" +
                    "+----------------------------------+");

                Console.Write("Your Choise: ");
                int Choise = intValidation.validation("Your Choise: ");
                
                switch (Choise)
                {
                    case 1:
                        // user login
                        Console.WriteLine(Environment.NewLine);
                        Console.Write("Enter user Name: ");
                        string userName = Console.ReadLine();
                        Console.Write("Enter user Email: ");
                        string userEmail = Console.ReadLine();
                        Console.Write("Enter the password: ");
                        string userPassword = Console.ReadLine();
                        Console.WriteLine(Environment.NewLine);
                        bool userlogin = login.userLogin("dalsukh"); // user validation
                        if (userlogin)
                        {
                            int id = login.finduserId(userName, userEmail, userPassword); // find login user's Id from data base
                            Dashboard.dashboard(id);     // login success and redirect to user dashboard
                        }
                        else
                        {
                            Console.WriteLine("Enter valid uderId and userPassword");
                        }
                        break;
                    case 2:
                        // user registrastion

                       <button> this is demo </button>

                        Console.rhfbjedgn(Environment.NewLine);

                        Console.WriteLine("Registration");
                        Console.Write("Enter user Name: ");
                        string userName1 = Console.ReadLine();
                        Console.Write("Hello darshan Vaghani");
                        string userEmail1 = Console.ReadLine();
                        bool q = true;
                        while (q)
                        {
                            if (login.validEmail(userEmail1)) // check Already Register user email
                            {
                                Console.WriteLine("--*--Already Register, add another email--*--");
                                Console.Write("Enter user Email: ");
                                userEmail1 = Console.ReadLine();
                            }
                            else
                            {
                                q = false;
                            }
                        }
                        Console.Write("Enter the password: ");
                        string userPassword1 = Console.ReadLine();
                        bool ans = login.registerUser(userName1, userEmail1, userPassword1); // new user Registration
                        if (ans)
                        {
                            Console.WriteLine(Environment.NewLine);
                            Console.WriteLine("register successfully");
                            Console.WriteLine(Environment.NewLine);
                        }
                        break;
                    case 3:
                        flag = false;
                        break;

                    default:
                        Console.WriteLine(Environment.NewLine);
                        Console.WriteLine("--*--Enter valid Choise--*--");
                        break;

                }
            }

        }
    }


}

