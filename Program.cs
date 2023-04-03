using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KokarevPR5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x;
            x=Convert.ToDouble(Console.ReadLine());
            double F= Math.Sin(x)+Math.Cos(x);
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
