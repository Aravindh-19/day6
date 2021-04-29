using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> keyValuepairs = new Dictionary<int, string>();
            keyValuepairs.Add(1, "abd");
            keyValuepairs.Add(2, "dev");
            keyValuepairs.Add(3, "Maxi");
            if(keyValuepairs.ContainsKey(2))
            {
                Console.WriteLine("Key found");
            }
            else
            {
                Console.WriteLine("Key not found");
            }
            if (keyValuepairs.ContainsValue("abd"))
            {
                Console.WriteLine("value found");
            }
            else
            {
                Console.WriteLine("value not found");
            }
            Console.ReadLine();
        }
    }
}
