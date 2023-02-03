using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    internal class Test
    {
        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>
            {
                new Computer(1), new Computer(53), new Computer(12), new Computer(23), new Computer(44), new Computer(25)
            };
            var c = from Computer computer in computers where computer.id <20 select computer;
            foreach(var filteredComputers in c)
            {
                Console.WriteLine(filteredComputers+" id: "+ filteredComputers.getId());
            }
            Console.ReadKey();
        }
    }
    class Computer
    {
        public Computer(int id) { this.id = id; }
       public int id { get; private set; }
        public int getId()
        {
            return id;
        }
    }
}
