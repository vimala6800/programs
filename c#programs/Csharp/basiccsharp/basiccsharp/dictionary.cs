using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basiccsharp
{
    internal class dictionary
    {
        public static void demo()
        {
            IDictionary<int, string> a = new Dictionary<int, string>();
            a.Add(1, "one");//adding key value using Add() method
            a.Add(2, "two");
            a.Add(3, "three");

            foreach (KeyValuePair<int, string> kvp in a)
            {
                Console.WriteLine("key:{0},value:{0}", kvp.Key, kvp.Value);
            }
            var cities = new Dictionary<string, string>()
            {
                {"uk","london,manchester,birmingham" },
                {"usa","chicogo,new york,washington" },
                {"india","mumbai,new Delhi,pune" }
            };
            foreach (var kvp in cities)
            {
                Console.WriteLine("key:{0},Value:{1}", kvp.Key, kvp.Value);

            }
        }
        public static void demo1()
        {
            var cities = new Dictionary<string, string>(){
            {"UK", "London, Manchester, Birmingham"},
            {"USA", "Chicago, New York, Washington"},
            {"India", "Mumbai, New Delhi, Pune"}
        };

            Console.WriteLine(cities["UK"]);
            Console.WriteLine(cities["USA"]);



            Console.WriteLine("---access elements using for loop---");

            for (int i = 0; i < cities.Count; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1}",
                                                        cities.ElementAt(i).Key,
                                                        cities.ElementAt(i).Value);
            }
        }

        public static void demo2()
        {
            var cities = new Dictionary<string, string>(){
            {"UK", "London, Manchester, Birmingham"},
            {"USA", "Chicago, New York, Washington"},
            {"India", "Mumbai, New Delhi, Pune"}
        };
            cities["UK"] = "Liverpool, Bristol"; // update value of UK key
            cities["USA"] = "Los Angeles, Boston"; // update value of USA key
                                                   //cities["France"] = "Paris"; //throws run-time exception: KeyNotFoundException

            if (cities.ContainsKey("France"))
            {
                cities["France"] = "Paris";
            }

            foreach (var kvp in cities)
                Console.WriteLine("Key: {0}, Value:{1}", kvp.Key, kvp.Value);
        }


        public static void demo3()
        {
            var cities = new Dictionary<string, string>(){
            {"UK", "London, Manchester, Birmingham"},
            {"USA", "Chicago, New York, Washington"},
            {"India", "Mumbai, New Delhi, Pune"}
        };

            Console.WriteLine("Total Elements: {0}", cities.Count);

            cities.Remove("UK"); // removes UK 
                                 //cities.Remove("France"); //throws run-time exception: KeyNotFoundException

            if (cities.ContainsKey("France"))
            { // check key before removing it
                cities.Remove("France");
            }

            Console.WriteLine("Total Elements: {0}", cities.Count);

            cities.Clear(); //deletes all elements

            Console.WriteLine("Total Elements after Clear(): {0}", cities.Count);

        }

       
    }
}





    




