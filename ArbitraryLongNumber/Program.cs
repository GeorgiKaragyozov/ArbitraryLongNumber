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
            ArbitraryLong x = new ArbitraryLong("-8636298269832141412634");
            ArbitraryLong y = new ArbitraryLong("-981412684218");
            Console.WriteLine(ArbitraryLong.Division(x, y));


            Console.ReadKey();
        }
    }
}
