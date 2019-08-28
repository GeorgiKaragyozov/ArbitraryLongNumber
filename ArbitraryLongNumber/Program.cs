using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbitraryLongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            ArbitraryLong x = new ArbitraryLong(-22);
            ArbitraryLong y = new ArbitraryLong(11);

            Console.WriteLine(ArbitraryLong.Addition(x, y)); 
            

            Console.ReadKey();
        }
    }
}
