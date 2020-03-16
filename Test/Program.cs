using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //hello
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Zsombor");
            }

            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);

            Console.ReadLine();
        }
    }
}
