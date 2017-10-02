using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp1
{
    // just a simple product POCO class.  
    public class Product
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Category { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            var products = new List<Product>
            {
                new Product { Name = "CD Player", Id = 1, Category = "Electronics" },
                new Product { Name = "DVD Player", Id = 2, Category = "Electronics" },
                new Product { Name = "Blu-Ray Player", Id = 3, Category = "Electronics" },
                new Product { Name = "LCD TV", Id = 4, Category = "Electronics" },
                new Product { Name = "Wiper Fluid", Id = 5, Category = "Automotive" },
                new Product { Name = "LED TV", Id = 6, Category = "Electronics" },
                new Product { Name = "VHS Player", Id = 7, Category = "Electronics" },
                new Product { Name = "Mud Flaps", Id = 8, Category = "Automotive" },
                new Product { Name = "Plasma TV", Id = 9, Category = "Electronics" },
                new Product { Name = "Washer", Id = 10, Category = "Appliances" },
                new Product { Name = "Stove", Id = 11, Category = "Electronics" },
                new Product { Name = "Dryer", Id = 12, Category = "Electronics" },
                new Product { Name = "Cup Holder", Id = 13, Category = "Automotive" },
            };
            var dic = products.Aggregate(new Dictionary<String,int[]>(), (map,k) =>
            {
                var name = k.Name.Substring(0, 1);
                int[] value = map.ContainsKey(name)?map[name]: new int[2] { 0, 0 };
                value[0] += 1;
                map[name] = value;
                return map;

            });
            foreach (var keyValuePair in dic)
            {
                Console.Out.Write(keyValuePair.Key+":"+keyValuePair.Value[0]+"\n");
            }
     


            Console.In.Read();
        }
    }
}
