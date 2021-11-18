using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcepts.Abstraction
{
    abstract class Animal
    {
        public abstract void animalSound();
        public void sleep()
        {
            Console.WriteLine("Animal needs to sleep");
            Console.ReadLine();
        }
    }

    class Cat : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The Cat says: meao meao");
            Console.ReadLine();
        }
    }
}