using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack s1=new Stack();
            s1.Push(1);
            Queue q1=new Queue();
            q1.Enqueue(1);
            ArrayList arrayList = new ArrayList();
            Console.WriteLine(arrayList.Capacity);
            arrayList.Add(767);
            arrayList.Add(755);
            arrayList.Add("fggh");
            arrayList.Add(true);
            foreach(object i in arrayList)      //use obj to get int,string.
            {
                Console.WriteLine(i);
            }
        }
    }
}
