using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Person2 person2 = new Person2(32);
          Console.WriteLine(person.getValue());
           
        }
        class Person{
            private int value;
            public string getValue()
            {
                return value.ToString();
            }
            public Person(int value) { 
                this.value = value;
            }
            public Person() { }

        }
        class Person2: Person
        {
            public Person2(int value) : base(value){ }
        }
    }
}
