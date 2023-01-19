using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test6
{
    internal class Program
    {
      static void func(int a, int b, ref int result)
        {
            result = (int)Convert.ToDouble(Math.Pow(a, b));
        }
        static void func2(int value1, int value2, out int result2)
        {
            result2 = value1 / value2;
        }
        static void Main(string[] args)
        {
            int a = 2, b = 12 ,result = 0;
            func(a, b, ref result);
            Console.WriteLine(result);

            /////////////

            int value1 = 100, value2 = 2, result2;
            func2(value1, value2, out result2);
            Console.WriteLine(result2);
            Console.ReadKey();

        }

    }
}
