using System;

namespace EditedShit
{
    //After
    internal class Edit
    {
        static double function(double a, double b, double c)
        {
            return (Math.Pow(a, 5) - Math.Pow(a, 3) * Math.Sqrt(b)) / (2 * c);
        }
        static void Main(string[] args)
        {
            double a, b, c;
            Console.Write("Введите a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите c: ");
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(function(a, b, c));
            Console.ReadKey();
        }
    }
    }



/*  Before
 *  
 *  
 *  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace ConsoleApplication39
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Введите a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите c: ");
            c = Convert.ToDouble(Console.ReadLine());
 
            new Reshenie(a,b,c).raschet();
            Console.ReadKey();
        }
    }
    class Reshenie
    {
        private double a;
        private double b;
        private double c;
        private double D;
        private double x1;
        private double x2;
        public Reshenie(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void raschet()
        {
            D = (Math.Pow(a, 5) - Math.Pow(a, 3) * Math.Sqrt(b)) / (2 * c);
            Console.WriteLine("Ответ: {0}", D);
            Console.ReadKey();
        }
    }
}
*/