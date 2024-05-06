using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACDI.Dog
{
    /*public class Dog
    {
        public string Name { get; set; }
        public void Bark()
        {
            Console.WriteLine($"{Name} makes a sound.");
        }
    }
    public class Cat
    {
        public string Name { get; set; }
        public void Meow()
        {
            Console.WriteLine($"{Name} makes a sound.");
        }
    }*/
    public abstract class Animal
    {
        public string Name { get; set; }
        public abstract void MakeSound();
    }
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} barks.");
        }
    }
    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} meows.");
        }
    }
}
