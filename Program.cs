using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(1, 12));
            }
            Console.ReadKey();
        }
    }
}
