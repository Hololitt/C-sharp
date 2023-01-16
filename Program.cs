using System;
using System.Threading;
namespace Test
{
        internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Person person = new Person(random.Next(50, 100), random.Next(50, 100),
                random.Next(40, 80), random.Next(40, 80),
                random.Next(15, 20), random.Next(10, 15));
        }
    }
   class Person
    {
       public Person(int health1, int health2, int armor1, int armor2, int damage1, int damage2)
        {
            Person1 person1 = new Person1(health1, armor1, damage1);
            Person2 person2 = new Person2(health2, armor2, damage2);
           
                Console.WriteLine($"Person1: health {person1.getHealth()} armor {person1.getArmor()} damage {person1.getDamage()}");
                Thread.Sleep(1000);
                Console.WriteLine($"Person2: health {person2.getHealth()} armor {person2.getArmor()} damage {person2.getDamage()}");
                Thread.Sleep(1000);
                while (true)
                {
                if(person1.getHealth() <= 0){
                    break;
                }else if(person2.getHealth() <= 0)
                {
                    break;
                }
                person1.setHealth(person2.getDamage() & person1.getArmor());
                person2.setTotalDamage(person2.getDamage() & person1.getArmor());
                    person2.setHealth(person1.getDamage() & person2.getArmor());
                person1.setTotalDamage(person1.getDamage() & person2.getArmor());
                    Console.WriteLine($"Person1: health {person1.getHealth()}");
                    Thread.Sleep(600);
                    Console.WriteLine($"person2: health {person2.getHealth()}");
                }
               if(person1.getHealth() > person2.getHealth())
                {
                    Console.WriteLine("Person1 win");
                }
                else
                {
                    Console.WriteLine("Person2 win");
                }
            Thread.Sleep(2000);
            person1.checkTotalDamage();
            person2.checkTotalDamage();
            Console.ReadKey();
        }
        
    }
    class Person1
    {
        public Person1(int health, int armor, int damage)
        {
            this.health = health;
            this.armor = armor;
            this.damage = damage;
        }
        private int health;
        private int armor;
        private int damage;

  public int getHealth()
        {
            return health;
        }
        public int getArmor()
        {
            return armor;
        }
        public int getDamage()
        {
            return damage;
        }
        public void setHealth(int health)
        {
            this.health -= health;
        }
        private int totalDamage;
        public void setTotalDamage(int damage) { 
            totalDamage+= damage;
        }
      public void checkTotalDamage()
        {
            Console.WriteLine($"Total damage of person1: {totalDamage}");
        }

    }
    class Person2
    {
        public Person2(int health, int armor, int damage)
        {
            this.health = health;
            this.armor = armor;
            this.damage = damage;
        }
        private int health;
        private int armor;
        private int damage;
        private int totalDamage;
    public int getHealth()
        {
            return health;
        }
        public int getArmor()
        {
            return armor;
        }
        public int getDamage()
        {
            return damage;
        }
        public void setHealth(int health)
        {
            this.health -= health;
        }
       public void setTotalDamage(int damage)
        {
            totalDamage+= damage;
        }
        public void checkTotalDamage()
        {
            Console.WriteLine($"Total damage of person2: {totalDamage}");
        }
    }
}
