using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasic02
{
    class Person
    {
        public string firstName;
        public string middleName;
        public string lastName;
        public string Id;

        public Person(string firstName, string middleName, string lastName)
            :this(firstName, lastName)
        {
            this.middleName = middleName;
        }

        public Person(string firstName, string lastName):this()
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Person()
        {
            Id = "0000";
        }

        public string GetFullName()
        {
            string fullName;
            if (middleName != null)
            {
                fullName = firstName + " " + middleName + " " + lastName;
            }
            else
            {
                fullName = firstName + lastName;
            }

            return fullName;
        }

        public string GetReverseName()
        {
            string fullName = GetFullName();
            char[] charArray = fullName.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
