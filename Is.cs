using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Human();
            Person person2 = new Woman();
          if(person is Human human)
            {
                human.getInfo();
               
            }
          if(person2 is Woman woman)
            {
                woman.getInfo();
            }
            Console.ReadKey();
        }
    }
    class Person
    {
        private int id;
        private string name;
        public Person(int id, string name) { this.id = id; this.name = name; }
      
        public void getInfo()
        {
            Console.WriteLine($"id: {id}    name: {name}");
        }

    }
    class Human : Person
    {
        private int id;
        private string name;
        public Human(int id = 1, string name = "Key") : base(id, name) {
            this.id = id;
            this.name = name;
        }
    }
    class Woman : Person
    {
        private int id;
        private string name;
        public Woman(int id = 2, string name = "wash machine") : base(id, name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
