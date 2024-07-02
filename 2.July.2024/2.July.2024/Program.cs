using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;
using task_02_try_2_July;

namespace task_02_try_2_July
{

    interface Isound
    {
        void MakeSound();
    }

    public abstract class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            this.Name = name;
        }

        public abstract void Eat();
        public void Sleep()
        {
            Console.WriteLine($"The {Name} is sleeping zZzZzZ");
        }



    }

    class Dog : Animal, Isound
    {
        public Dog(string name) : base(name)
        {
        }

        public override void Eat()
        {
            Console.WriteLine($"The {Name} is eating Spaghetti.");
        }

        public void MakeSound()
        {
            Console.WriteLine($"{Name} sound is Woof Woof!");
        }
    }


    class Cat : Animal, Isound
    {
        public Cat(string name) : base(name)
        {
        }

        public override void Eat()
        {
            Console.WriteLine($"The {Name} is eating yogurt.");
        }

        public void MakeSound()
        {
            Console.WriteLine($"{Name} sound is Mewo Meow!\n");
        }



    }


}
internal class Program
{
    static void Main(string[] args)
    {

        Dog dog = new Dog("Puppy");
        dog.MakeSound();
        dog.Eat();
        dog.Sleep();


        Cat kitty = new Cat("Kitty");
        kitty.MakeSound();
        kitty.Eat();
        kitty.Sleep();
    }
}

