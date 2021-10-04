using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples3and5
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> numbers = new HashSet<int>();
            for (int i = 3; i < 1000; i += 3)
            {
                numbers.Add(i);
            }

            //Multiples of 3
            int sum1 = numbers.Sum();
            Console.WriteLine(sum1);
            Console.ReadLine();

            HashSet<int> numbers2 = new HashSet<int>();
            for (int j = 5; j < 1000; j += 5)
            {
                numbers.Add(j);
            }

            //Multiples of 5
            int sum2 = numbers.Sum();
            Console.WriteLine(sum2);
            Console.ReadLine();

            //Both
            int sum3 = (sum1 + sum2);
            Console.WriteLine(sum3);
            Console.ReadLine();

        }
    }
}