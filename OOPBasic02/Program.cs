using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasic02
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Md.","Imran","Habib");
            Console.WriteLine(person1.GetFullName());

            Person person2 = new Person("Imran", "Habib");
            Console.WriteLine(person2.GetFullName());
            Console.ReadKey();

        }
    }
}
