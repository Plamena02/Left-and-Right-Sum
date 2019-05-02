using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var sum1 = 0;
            var diff = 0;
            for (int i = 1; i <= n; i++)
            { var a = int.Parse(Console.ReadLine());
                 sum =sum+ a;
            }
            for (int i = 1; i <= n; i++)
            {
                var b = int.Parse(Console.ReadLine());
                sum1 =sum1 +b;
            }
            if (sum == sum1)
            { Console.WriteLine("Yes, sum = " + sum); }
            else { diff = sum - sum1; Console.WriteLine("No, diff = " + Math.Abs(diff)); }


        }
    }
}
