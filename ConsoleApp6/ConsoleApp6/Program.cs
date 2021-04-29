using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> ts = new HashSet<int>();
            ts.Add(1); ts.Add(2);ts.Add(3);
            foreach(var item in ts)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
