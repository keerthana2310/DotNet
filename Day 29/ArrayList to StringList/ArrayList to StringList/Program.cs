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
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_to_StringList
{
    internal class Program
    {
        public static string[] ConvertToStringArray(ArrayList arraylist)
        {
            arraylist.Sort();
            string[] arr1 = new string[arraylist.Count];
            // arraylist.ToArray();

            for (int i=0;i<arraylist.Count;i++)
            {
                arr1[i] = arraylist[i].ToString();
            }
            
            return arr1;
            
           
        }
        static void Main(string[] args)
        {
          
            ArrayList arrayList = new ArrayList();

            Console.WriteLine("Enter the n of  string");
            int n = int.Parse(Console.ReadLine());

          //  string[] str=new string[n];
            //string[] arr = new string[n];





            Console.WriteLine("Enter the string");
            for (int i = 0; i < n; i++)
            {
               // str[i] = Console.ReadLine();
                  arrayList.Add(Console.ReadLine());

            }
            Console.WriteLine("strings entered are");

           /* foreach (string i in arrayList)
            {
                Console.WriteLine(i);
            }*/

            //List<string> arr = new List<string>();


            //int[] a = new int[5];
            //for(int i=0; i<n.Length; i++)
            //{

            //    arrayList.add(str);
            //}

            string[] arr = ConvertToStringArray(arrayList);
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
                
                

            
        }
    }
}
