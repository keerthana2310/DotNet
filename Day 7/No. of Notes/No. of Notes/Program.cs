//write a program to enter an amount and findout minnumber of notes required to make the amount
using System;


namespace No.of_Notes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount:");
            int amount = int.Parse(Console.ReadLine());

            int note1 = amount / 2000;
            Console.WriteLine(note1  + " RS.2000");
            amount= amount %2000;
            int note2 = amount / 1000;
            Console.WriteLine(note2 + " RS.1000");
            amount = amount % 1000;
            int note3 = amount / 500;
            Console.WriteLine(note3  + " RS.500");
            amount = amount % 500;
            int note4 = amount / 200;
            Console.WriteLine(note4  + " RS.200");
            amount = amount % 200;
            int note5 = amount / 100;
            Console.WriteLine(note5 + " RS.100");
            amount = amount % 100;
            int note6 = amount / 50;
            Console.WriteLine(note6 + " RS.50");
            amount = amount % 50;
            int note7 = amount / 20;
            Console.WriteLine(note7 + " RS.20");
            amount = amount % 20;
            int note8 = amount / 10;
            Console.WriteLine(note8 + " RS.10");
            amount = amount % 10;
            int note9 = amount /5;
            Console.WriteLine(note9 + " RS.5");
            amount = amount % 5;


           
                
                
            
        }
    }
}
