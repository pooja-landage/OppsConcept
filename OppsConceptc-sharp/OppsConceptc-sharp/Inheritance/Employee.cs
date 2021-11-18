using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppsConcepts.Inheritance
{
    public class Employee
    {
        public void Billing()
        {
            Console.WriteLine("Employee is doing Billing");
            Console.ReadLine();
        }
    }

    public class  Customer:Employee
    {
        public  void BillSlip()
        {
            Console.WriteLine("Customer is paying the Bill");
            Console.ReadLine();
        }
    }
}
