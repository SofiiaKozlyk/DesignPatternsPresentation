using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RB.Bird
{
    /*public interface IBird
    {
        public void Fly();
        public void Swim();
    }
    public class Swan : IBird
    {
        public void Fly()
        {
            Console.WriteLine("Flying...");
        }
        public void Swim()
        {
            Console.WriteLine("Swimming...");
        }
    }
    public class Penguin : IBird
    {
        public void Fly()
        {
            throw new NotImplementedException();
        }
        public void Swim()
        {
            Console.WriteLine("Swimming...");
        }
    }*/
    public interface IFlyingBird
    {
        public void Fly();
    }
    public interface ISwimmingBird
    {
        public void Swim();
    }
    public class Swan : IFlyingBird, ISwimmingBird
    {
        public void Fly()
        {
            Console.WriteLine("Flying...");
        }
        public void Swim()
        {
            Console.WriteLine("Swimming...");
        }
    }
    public class Penguin : ISwimmingBird
    {
        public void Swim()
        {
            Console.WriteLine("Swimming...");
        }
    }
}
