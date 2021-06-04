using System;
using System.Collections.Generic;
using System.Collections;

namespace VeryFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //List<String> customers = new List<string>();
            //customers.Add("Heineken");
            //customers.Add("Marriot Executives");
            //customers.Add("Starbucks");
            //customers.Add("McDonald's");

            //foreach (var item in customers)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(customers.Count);
            //Console.WriteLine(customers[3]);


            //Dictionary<String, String> config = new Dictionary<string, string>();
            //config.Add("resolution", "1920x1080");
            //config.Add("title", "Some_website");

            //Console.WriteLine(config["title"]);

            //foreach (var item in config)
            //{
            //    Console.WriteLine(item.Key);
            //    Console.WriteLine(item.Value);
            //}


            ArrayList list = new ArrayList();
            list.Add("a string");

      
            Console.WriteLine(list[0].ToString().Length);

        }
    }
}
