using System;

namespace Test8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Human1 human1 = person as Human1;
            Human2 human2 = person as Human2;
           if(human1 != null) {
                human1.getInfo();
            }
           if(human2 != null)
            {
                human2.getInfo();
            }
        }
    }
        }
class Person
{
    public Person(string name = "default name", int age = 0) { }
    public int age { get; private set; }
    public string name { get; private set; }
    public void getInfo()
    {
        Console.WriteLine($"My name is {name} and I`m {age} years old");
    }
}
class Human1 : Person
{
    public Human1(string name, int age) : base(name, age) { this.name = name; this.age = age; }
    public int age { get; private set;}
    public string name { get; private set;}
}
class Human2 : Person
{
    Human2(string name, int age) : base(name, age) { this.age = age; this.name = name; }
    public int age { get;  set; }
    public string name { get; set; }
}
