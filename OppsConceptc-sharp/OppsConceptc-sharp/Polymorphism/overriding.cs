using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcepts.Polymorphism
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animals are Eating");
            Console.ReadLine();
        }
    }
    public class Dog: Animal
    {
        public void Eat()
        {
            Console.WriteLine("Dog are Eating");
            Console.ReadLine();
        }
    }
}
