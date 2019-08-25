using System;
using System.Collections.Generic;

namespace Epam_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("person1", 23, new List<string>() { "123456", "123567", "1111111" });
            Person person2 = new Person("person2", 25, new List<string>() { "123456", "123567" });
            Person person3 = new Person("person3", 27, new List<string>() { "123456", "123567" });
            Person person4 = new Person("person4", 22, new List<string>() { "123456", "123567", "44444444" });
            Person person5 = new Person("person5", 30, new List<string>() { "123456", "123567" });
            Person person6 = new Person("person6", 19, new List<string>() { "123456", "123567" });
           

       
            List<Person> people = new List<Person>();
            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);
            people.Add(person5);
            people.Add(person6);


            foreach (var item in people)
            {
                item.PrintAll();
            }

            Person person7 = new Person("person7", 30, new List<string>() { "123456", "123567" });
            Person person8 = new Person("person8", 19, new List<string>() { "123456", "123567" ,"3456789" });
            List<Person> newPeople = new List<Person>();
            newPeople.Add(person7);
            newPeople.Add(person8);

            people.AddRange(newPeople);

            foreach (var item in people)
            {
                item.PrintNumbers();
            }

        } }

}
