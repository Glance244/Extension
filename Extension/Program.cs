using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "John is afraid of dogs,  He should run now!!";
            Console.WriteLine(s);
            Console.WriteLine("Words: "+s.WordCount());


            Console.Write("Enter John's age: ");
            int iAge = Console.ReadLine().Parse();
            Console.WriteLine("Age: "+iAge);
            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
