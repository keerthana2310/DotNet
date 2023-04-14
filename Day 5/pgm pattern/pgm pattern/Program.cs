using System;


namespace pgm_pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i; 
            int j;
            Console.WriteLine("pattern printing is");
            for (i= 1; i<=5; i++)
            {
                for(j=1;j<=i;j++)
                {
                    Console.Write(i);         //can use j ,*
                }
                Console.WriteLine();
            }

        }
    }
}
