using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
           int humanId= human.setId = 1;
            Console.WriteLine(humanId);
            Console.ReadKey();
        }
    }
    class Human
    {
        private int id;
        public int setId
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }
    }
}