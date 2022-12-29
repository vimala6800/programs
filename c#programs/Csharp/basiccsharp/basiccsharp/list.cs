using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basiccsharp
{
    internal class list
    {
        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        public static void demo()
        {
            // adding elements using add() method
            var primeNumbers = new List<int>();
            primeNumbers.Add(1);
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);

            Console.WriteLine("No of elelemts: " + primeNumbers.Count);

            var cities = new List<string>();
            cities.Add("New York");
            cities.Add("London");
            cities.Add("Mumbai");
            cities.Add("Chicago");
            cities.Add(null); // null is allowed

            Console.WriteLine("No of elelemts: " + cities.Count);

            // adding elements using collection initializer syntax
            var bigCities = new List<string>() { "New York", "London", "Mumbai", "Chicago" };

            Console.WriteLine("No of elelemts: " + bigCities.Count);

            var students = new List<Student>() {
                new Student(){ Id = 1, Name="Bill"},
                new Student(){ Id = 2, Name="Steve"},
                new Student(){ Id = 3, Name="Ram"},
                new Student(){ Id = 4, Name="Abdul"}
            };

            Console.WriteLine("No of elelemts: " + students.Count);
        }
        public static void demo1()
        {
            string[] cities = new string[3] { "Mumbai", "London", "New York" };

            var popularCities = new List<string>();

            // adding an array in a List
            popularCities.AddRange(cities);

            var favouriteCities = new List<string>();

            // adding a List 
            favouriteCities.AddRange(popularCities);

            Console.WriteLine(popularCities.Count);
            Console.WriteLine(favouriteCities.Count);

        }
        public static void demo2()
        {
            List<int> intList = new List<int>() { 10, 20, 30, 40, 50 };

            intList.ForEach(el => Console.WriteLine(el));

            foreach (var el in intList)
                Console.WriteLine(el);

            for (int i = 0; i < intList.Count; i++)
                Console.WriteLine(intList[i]);

        }
        public static void demo3()
        {
            var students = new List<Student>() {
                new Student(){ Id = 1, Name="Bill" },
                new Student(){ Id = 2, Name="Steve" },
                new Student(){ Id = 3, Name="Ram" },
                new Student(){ Id = 4, Name="Abdul" },
                new Student(){ Id = 5, Name="Bill" }
        };

            //get all students whose name is Bill
            var studNames = from s in students
                            where s.Name == "Bill"
                            select s;

            foreach (var student in studNames)
                Console.WriteLine(student.Id + ", " + student.Name);
        }
        public static void demo4()
        {
            var numbers = new List<int>() { 10, 20, 30, 40 };

            numbers.Insert(1, 11);// inserts 11 at 1st index: after 10.

            foreach (var num in numbers)
                Console.WriteLine(num);
        }
        public static void demo5()
        {
            var numbers = new List<int>() { 10, 20, 30, 40, 10 };

            numbers.Remove(10); // removes 10 elements from a list

            numbers.RemoveAt(2); //removes the 3rd element (index starts from 0)

            //numbers.RemoveAt(10); //removes the 3rd element (index starts from 0)

            foreach (var num in numbers)
                Console.WriteLine(num);
        }

        public static void demo6()
        {
            var numbers = new List<int>() { 10, 20, 30, 40 };

            Console.WriteLine(numbers.Contains(10));
            Console.WriteLine(numbers.Contains(11));
            Console.WriteLine(numbers.Contains(20));
        }

    }
}

