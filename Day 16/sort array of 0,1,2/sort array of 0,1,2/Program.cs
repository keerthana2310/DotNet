using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_array_of_0_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int low = 0;
            //int mid = 0;
            //int high = n- 1;
            //int a;
            //while(mid<=high)
            //{
            //    if (a[mid]==0)
            //    {
            //        int temp = a[low];
            //        a[low] = a[mid];
            //        a[mid] = temp;
            //        low++;
            //        mid++;
            //    }
            //    else if (a[mid]==2)
            //    {

            //        int temp = a[high];
            //        a[high] = a[mid];
            //        a[mid] = temp;
            //        high--;
            //    }
            int[] A = { 1, 0, 0, 1, 2, 2, 1, 0 };
            int n = A.Length;
            int count0 = 0, count1 = 0, count2= 0;
            int i = 0;
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(i);
            }
            for (i = 0; i < n; i++)
            {
                if (A[i] == 0)
                {
                    count0 += 1;
                }
                if (A[i] == 1)
                {
                    count1 += 1;
                }
                if (A[i] == 2)
                {
                    count2 += 1;
                }
            }

        
              for(i=0;i<count0;i++)
            {
            A[i]=0;
            }
            for(i=count0;i<count0+count1;i++)
                  {
            A[i]=1;
                 }

            for(i=count0+count1;i<n;i++)
            {
                A[i] = 2;
            }
            Console.WriteLine("After sorting");
            for(i=0;i<n;i++)
            {
                Console.Write(A[i]);
            }
        }
    }
}
