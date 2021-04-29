using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            List<int> mylist = new List<int>();
            mylist.Add(input);
            int inputmylist = Convert.ToInt32(Console.ReadLine());
            mylist.Add(inputmylist);
            foreach (var item in mylist)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}