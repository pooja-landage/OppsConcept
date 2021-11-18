using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcepts.Polymorphism
{
    public class overloading
    {
        public void Add(int a,int b)
        {
            Console.WriteLine(a + b);
            Console.ReadLine();
        }
        public void Add(float a, float b)
        {
            Console.WriteLine(a + b);
            Console.ReadLine();
        }
    }
}
