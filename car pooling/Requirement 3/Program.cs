using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement_3
{
    internal class Program
    {
        private static DateTime currentDate;

        static void Main(string[] args)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1) Valid Car Registration Number");
            Console.WriteLine("2) Convert Car Registration Number");
            Console.WriteLine("3) Valid Driving License");
            Console.WriteLine("1) Enter choice:");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Car Registration Number:");
                    string carRegNumber = Console.ReadLine();
                    if (IsValidCarRegistrationNumber(carRegNumber))
                        Console.WriteLine(carRegNumber + "is Valid");
                    else
                        Console.WriteLine(carRegNumber + "is Invalid");
                    break;
                case 2:
                    Console.WriteLine("Enter car registration number:");
                    string carRegNumberToConvert = Console.ReadLine();
                    string ConvertedCarRegistrationNumber = ConvertCarRegistrationNumber(carRegNumberToConvert);
                    Console.WriteLine(ConvertedCarRegistrationNumber);
                    break;
                case 3:
                    Console.WriteLine("Enter driving license issue date(dd-mm-yyyy):");
                    DateTime issueDate = DateTime.ParseExact(Console.ReadLine(), "dd-mm-yyyy", null);
                    if (IsValidDrivingLicense(issueDate))
                        Console.WriteLine((DateTime.Now.Year - issueDate.Year) + "years old license-expired");
                    else
                    {
                        Console.WriteLine((DateTime.Now.Year - issueDate.Year) + "years old license-valid");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
        static bool IsValidCarRegistrationNumber(string carRegNumber)
        {
            string pattern =//"^[A-Z]{2}[\\-]{0,1}[0-9]{2][\\-]{0}"
                @"^[A-Z]{2}-\D{2}-[A-Z]{2}-\D{4}$";
            return System.Text.RegularExpressions.Regex.IsMatch(carRegNumber, pattern);
                
        }
        static string ConvertCarRegistrationNumber(string carRegNumber)
        {
            return carRegNumber.Replace('@', '-').Replace('*', '-').ToUpper();
        }
        static bool IsValidDrivingLicense(DateTime issueDate)
        {
            DateTime cuurentDate = DateTime.Now;
            DateTime expiryDate = issueDate.AddYears(10);
            return currentDate > expiryDate;
        }

    }
}
