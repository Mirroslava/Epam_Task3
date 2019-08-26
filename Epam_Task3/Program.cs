using System;
using System.Collections.Generic;
using System.Text;

namespace Epam_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("person1", 23, new List<string>() { "123456", "123567", "1111111" });
            Person person2 = new Person("person2", 25, new List<string>() { "123456", "123567" , "44444444" });
            Person person3 = new Person("person3", 27, new List<string>() { "123456", "123567", "44444444" });
            Person person4 = new Person("person4", 22, new List<string>() { "123456", "123567", "44444444" });
            Person person5 = new Person("person5", 30, new List<string>() { "123456", "123567", "44444444" });
            Person person6 = new Person("person6", 19, new List<string>() { "123456", "123567", "44444444" });
           

       
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

            Console.WriteLine();
            Console.WriteLine("Task3");
            int N = 105;
            List<string> randomString = new List<string>();
            RandomGenerator generator = new RandomGenerator();
            for (int i = 0; i < N; i++)
            {
                string str = generator.RandomString(4, false);
                randomString.Add(str);
               
            }
            Console.WriteLine("A number of elements before sorting - {0}" ,N);


            for (int i = 0; i < randomString.Count; i++)
            {

                if (randomString[i].StartsWith('Z'))
                {
                    randomString.Remove(randomString[i]);
                }

            }

            randomString.Sort();
            randomString.Reverse();

            var noDupesList = new HashSet<string>(randomString);
            randomString.Clear();

            foreach (var item in noDupesList)
            {
                randomString.Add(item);
               
            }
            Console.WriteLine();
            Console.WriteLine("A number of elements after sorting - {0}", randomString.Count);

            void DisplayPage(int pageNumber)
            {

                string[] output = randomString.GetRange((pageNumber*5)-4, 5).ToArray();
                Console.WriteLine();
                foreach (string dinosaur in output)
                {
                    Console.WriteLine(dinosaur);
                }
            }

            bool check = true;
            int number = 0;
            while (check == true)
            {
                Console.WriteLine("Enter the number of page : ");
                string number1 =Console.ReadLine();
            
                if ((int.TryParse(number1, out number)) && Convert.ToInt32(number) != 0)
                {
                    DisplayPage(number);
                }
                else
                {
                    check = false;
                }
               

            }
        
            Console.WriteLine(randomString.Count);
        } }

}
