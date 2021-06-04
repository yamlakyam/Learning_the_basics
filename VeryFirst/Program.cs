using System;
using System.Collections.Generic;

namespace VeryFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<String> customers = new List<string>();
            customers.Add("Heineken");
            customers.Add("Marriot Executives");
            customers.Add("Starbucks");
            customers.Add("McDonald's");

            foreach (var item in customers)
            {
                Console.WriteLine(item);
            }


        }
    }
}
