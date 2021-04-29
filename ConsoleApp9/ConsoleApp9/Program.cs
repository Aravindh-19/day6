using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable h = new Hashtable();
            h.Add(3, "Welcome");
            h.Add(2, "to");
            h.Add(1, "C# class");
            ICollection key = h.Keys;
            foreach(var item in key)
            {
                Console.WriteLine(item+"-"+h[item]);
            }
            Console.ReadLine();
        }
    }
}
