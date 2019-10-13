using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasic
{
    class Person
    {
        public string firstName;
        public string middleName;
        public string lastName;

        public string GetFullName()
        {
            string fullName = firstName + " " + middleName + " " + lastName;
            return fullName;
        }

        public string GetReverseName()
        {
            string fullName = GetFullName();
            char[] charArray = fullName.ToCharArray();
            Array.Reverse(charArray);
            return  new string(charArray);
        }
    }
}
