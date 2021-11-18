using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcepts.ClassAndObject
{
    public class Calculator
    {
        public int  a;
        public int b;
        public int result;

        public void add()
        {
            result = a + b;
            Console.WriteLine(result);
            Console.ReadLine();
        }
        public void sub()
        {
            result = a - b;
            Console.WriteLine(result);
            Console.ReadLine();
        }

    }
}
