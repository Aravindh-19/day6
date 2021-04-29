using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> ts1 = new HashSet<int>();
            ts1.Add(1); ts1.Add(2); ts1.Add(3);
            HashSet<int> ts2 = new HashSet<int>();
            ts2.Add(1); ts2.Add(2); ts2.Add(3);
            Console.WriteLine(ts2.IsSubsetOf(ts1));
            Console.ReadLine();
        }
    }
}