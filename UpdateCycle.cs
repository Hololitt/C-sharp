using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UpdateCycles
{
    internal class UpdateCycle
    {
        static void Main(string[] args)
        {
            Machine[] machines = { new FirstMachine(), new SecondMachine()};
           while(true)
            {
               foreach(var machine in machines) { machine.work();
                    Thread.Sleep(1000);
                }
            }
            
        }
        class Machine
        {
            public virtual void work()
            {
                Console.WriteLine("It`s machine");
            }
        }
        class FirstMachine : Machine
        {
            public override void work()
            {
                base.work();
                Console.WriteLine("It`s first machine!");
            }
        }
        class SecondMachine : Machine
        {
            public override void work()
            {
                base.work();
                Console.WriteLine("It`s second machine!");
            }
        }
    }
}
