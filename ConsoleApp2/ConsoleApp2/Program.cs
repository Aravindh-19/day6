using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mylist = new List<int>();
            for (int i=5;i<10;i++)
            {
                mylist.Add(i * 2);
            }
            foreach (var item in mylist)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
