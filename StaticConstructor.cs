using System;

namespace StaticConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Machine machine = new Machine("Hello");
            Console.WriteLine("id from static constructor: "+Machine.id);
            Console.ReadLine();
        }
    }
    struct Machine
    {
        public static int id;
        static Machine()
        {
            id = 1;
        }
       public Machine(string word)
        {
            Console.WriteLine(word);
        }
    }
}
