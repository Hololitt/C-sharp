using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter word and value that will change with word");
            Console.WriteLine("Word: ");
            string word = Console.ReadLine();
            Console.WriteLine("Value: ");
            int value = Convert.ToInt32(Console.ReadLine());
            Function function = new Function(word,value);
            Console.WriteLine(function.start());
            Console.ReadKey();
        }
        class Function
        {
            private string word;
            private int value;
            public Function(string word, int value)
            {
                this.word = word;
                this.value = value;
          
            }
          public String start()
            {
                try
                {
                    value = Convert.ToInt32(word);
                    word = Convert.ToString(value);
                }
                catch(System.FormatException e)
                {
                    Console.WriteLine("Error");
                }
              

                return ($"Value: {this.value} Word: {this.word}");
            }

            }
            
        }
    }
