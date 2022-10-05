using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Block blok1 = new Block("1",2, 2, 3, 3);
            Block blok2 = new Block("2",2, 2, 4, 4);

            Console.WriteLine(blok1.Equals(blok2));

            Console.WriteLine(blok1);
            Console.WriteLine(blok2);

            Console.ReadKey();
        }
    }
}
