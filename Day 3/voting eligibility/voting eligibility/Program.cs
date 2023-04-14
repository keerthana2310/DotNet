using System;


namespace voting_eligibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter the age");
            age = int.Parse(Console.ReadLine());
            
           
            if(age>18)
            {
                Console.WriteLine("people eligible for vote");
            }
            else
            {
                Console.WriteLine("people are not eligible for vote");
            }

            Console.ReadLine();
        }
    }
}
