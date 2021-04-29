using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static Tuple<double,double>AddMulti(double a,double b)
        {
            return new Tuple<double, double>((a + b), (a * b));
        }
        static void Main(string[] args)
        {
            Tuple<double, double> output = Program.AddMulti(3.5, 2.0);
            Console.WriteLine("sum=" + output.Item1 + "           Multiplication=" + output.Item2);
            Console.ReadLine();

        }
    }
}
