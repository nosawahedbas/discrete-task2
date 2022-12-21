using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, num, x;

            Console.WriteLine("the smallest num");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("the biggests num");
            n2 = int.Parse(Console.ReadLine());
            for (num = n1; num < n2; num++)
            {
                decimal sum = 0;
                for (x = 1; x < num; x++)
                {
                    if (num % x == 0)
                        sum = sum + x;
                }
                if (sum == num)
                {
                    Console.WriteLine(num);
                }
            }


        }
    }
}
