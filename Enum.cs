using System;
using System.Collections.Generic;

namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
       List<Words> list = new List<Words>();
            list.Add(Words.computer);
            list.Add(Words.pan);
            list.Add(Words.head);
            list.Add(Words.table);
            list.Add(Words.wheel);
            list.Add(Words.sky);
            foreach(var words in list)
            {
                Console.WriteLine("Word in list: "+words);
            }
            for(int i = 1; i < list.Count; i++) { Console.WriteLine((Words) i); }
            Console.ReadKey();
            }
        }
    }
    enum Words
    {
        computer = 1, pan = 2, head = 3, table = 4, wheel = 5, sky = 6
    }
