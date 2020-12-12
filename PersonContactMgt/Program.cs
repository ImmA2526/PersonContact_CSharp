using System;
using System.Collections.Generic;
using System.Linq;
namespace PersonContactMgt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonClass> listPersonCity = new List<PersonClass>();
            Console.WriteLine("**** Welcome To Person Contact Mgt ****");
            AddRecord(listPersonCity);
            RetriveRecord(listPersonCity);
        }
        private static void AddRecord(List<PersonClass> listPersonCity)
        {
            listPersonCity.Add(new PersonClass("22223", "Imran", "Adarsh Nagar Pune", 24));
            listPersonCity.Add(new PersonClass("44453", "Nijam", "Manipura Colony Mumbai", 55));
            listPersonCity.Add(new PersonClass("45553", "Arti", "Kondhwa Khurd Latur", 22));
            listPersonCity.Add(new PersonClass("88987", "Pratibha", "Pratibha Villa Mumbai", 18));
            listPersonCity.Add(new PersonClass("22223", "Soham", "12 main strt Pune", 10));
            listPersonCity.Add(new PersonClass("44453", "Vidyadhar", "120 main strt Beed", 55));
            listPersonCity.Add(new PersonClass("45553", "Rehan", "Warali Mumbai", 22));
            listPersonCity.Add(new PersonClass("88987", "Sumit", "112 main street Latur", 18));
            Console.WriteLine();
        }
        public static void RetriveRecord(List<PersonClass>listPersonCity)
        {
            foreach (PersonClass Person in listPersonCity.FindAll(e => (e.Age < 10)).Take(2).ToList())
            {
                Console.WriteLine("Name:" + Person.Name + "\tAge:" + Person.Age);
            }
        }
    }
}