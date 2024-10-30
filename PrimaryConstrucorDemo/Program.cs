using PrimaryConstrucorDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryConstructorDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var product = new Product("Laptop", 1200);
            product.PrintDetails();  // Output: Laptop: $1200
            Console.ReadLine();
        }
    }
}
