using System;
using System.Collections.Generic;

namespace Epam_Task3
{
    public class Person
    {
        private string name;
        private int age;
        private IEnumerable<string> phoneNumbers;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public IEnumerable<string> PhoneNumbers { get => phoneNumbers; set => phoneNumbers = value; }


        public Person()
        {
            name = "";
            age = 0;
        }
        public Person(string _name, int _age , IEnumerable<string> _phoneNumbers)
        {
            name = _name;
            age  = _age;
            phoneNumbers = _phoneNumbers;
        }
        public void PrintAll()
        {
            Console.Write("\n Name " + Name + " Age " + Age + " PhoneNumbers : ");
            foreach (var item in phoneNumbers)
            {
                Console.Write(item + " ,"); ;
            }
           
        }
        public void PrintNumbers()
        {
            Console.Write("\n"+ Name+ " - ");
            foreach (var item in phoneNumbers)
            {
                Console.Write(item + " ,"); ;
            }

        }





    }

}
