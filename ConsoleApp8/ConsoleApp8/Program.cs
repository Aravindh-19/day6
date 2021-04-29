using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> vs = new LinkedList<string>();
            vs.AddLast("Abd");
            vs.AddLast("is");
            vs.AddLast("in");
            vs.AddLast("rcb");
            Console.WriteLine(vs.First.Value);
            Console.WriteLine(vs.Last.Value);
            Console.WriteLine(vs.Contains("rcb"));
            foreach ( var item in vs)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
