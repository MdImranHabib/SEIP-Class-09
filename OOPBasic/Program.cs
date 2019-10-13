using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.firstName = "Md.";
            person1.middleName = "Imran";
            person1.lastName = "Habib";
            string fullName = person1.GetFullName();
            string reverseName = person1.GetReverseName();

            Console.WriteLine(fullName);
            Console.WriteLine(reverseName);

            Console.WriteLine();

            Person person2=new Person();
            person2.firstName = "Bishwanath";
            person2.middleName = "Dey";
            person2.lastName = "Nayan";
            fullName = person2.GetFullName();
            reverseName = person2.GetReverseName();

            Person person3=new Person();

            person3 = person1;
            person1.middleName = "nayan";

            Console.WriteLine(fullName);
            Console.WriteLine(reverseName);

            Console.WriteLine(person3.GetFullName());

            Console.ReadKey();
        }
        
    }
}
