//Write a program that performs the following actions: Read n strings as input.
//Create an arraylist to store the above n strings in this arraylist.
//Write a function convertToStringArray which accepts the arraylist as input.
//The function should sort the elements (strings) present in the arraylist and convert them into a string array.
//Return the array.
//Include a class UserMainCode with the static method convertToStringArray which accepts an arraylist and returns an array.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace coversionlist
{
    internal class Program
    {
        public static string[] convertToStringArray(ArrayList array)

        { 
            array.Sort();
            string[] arr = new string[array.Count];
            for (int i = 0; i < array.Count; i++)
            {
                arr[i]=array[i].ToString();
            }
            return arr;

            
            }
        static void Main(string[] args)
        {
            ArrayList arraylist = new ArrayList();
            Console.WriteLine("Enter the n strings");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the string");

            for(int i=0; i<n; i++)
            {
                arraylist.Add(Console.ReadLine());   //each element is readed from the user 
            }
            Console.WriteLine("string entered are");

            string[] arr = convertToStringArray(arraylist);
          
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }

   
}
