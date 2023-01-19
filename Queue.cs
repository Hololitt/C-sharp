using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("c");
            queue.Enqueue("a");
            queue.Enqueue("b");

           queue.Dequeue();

           foreach(string itrem in queue)
            {
                Console.WriteLine(itrem);
                
            }
        }
    }
}
