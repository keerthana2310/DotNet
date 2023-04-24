﻿
using System;

namespace AccountApp
{
    public class Program
    {
        static void Main(string[] args)
        {

            int ch;
            Account a = null;

            do
            {

                Console.WriteLine("Account application");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Display account details");
                Console.WriteLine("3. Deposit  amount");
                Console.WriteLine("4.withdraw amount");
                Console.WriteLine("5.Balance amount");
                Console.WriteLine("0. Quit");
                Console.WriteLine("Enter your choice");

                ch = int.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 1:

                        Console.WriteLine("Enter your account id");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter your name");
                        string _name = Console.ReadLine();
                        Console.WriteLine("opening balance");
                        decimal _balance = decimal.Parse(Console.ReadLine());
                        a = new Account();
                        a.createaccount(id, _name, _balance);
                        break;

                    case 2:
                        if (a != null)
                        {
                            a.displayinfo();
                        }
                        else
                        {
                            Console.WriteLine("Create an account first");

                        }
                        break;

                    case 3:

                        if (a != null)
                        {
                            a.Deposit(5000);
                        }
                        else
                        {
                            Console.WriteLine("Create an account first");

                        }
                        break;
                    case 4:

                        if (a != null)
                        {
                            a.Withdraw(500);

                        }
                        else
                        {
                            Console.WriteLine("Create an account first");

                        }
                        break;
                    case 5:
                        if (a != null)
                        {
                            a.CheckBalance();
                        }
                        else
                        {
                            Console.WriteLine("Create an account first");

                        }

                        break;
                    case 0:

                        break;

                    default:

                        Console.WriteLine("Wrong choice");
                        break;

                }
                //{
                //Console.WriteLine("Thanks for using bank account");
                //}
            } while (ch != 0);
            {
                Console.WriteLine("Thanks for using bank account");
            }


        }
    }
}