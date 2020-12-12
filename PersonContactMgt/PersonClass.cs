using System;
using System.Collections.Generic;
using System.Text;

namespace PersonContactMgt
{
    public class PersonClass
    {
        public string SSN;
        public string Name;
        public string Address;
        public int Age;
        public PersonClass(string ssn,string name,string address,int age)
        {
            SSN = ssn;
            Name = name;
            Address = address;
            Age=age;
        }
    }
}
