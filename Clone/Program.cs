using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clone
{
    class House
    {
        public int Flour { get; set; }
        public string Color { get; set; }
        public int Size { get; set; }
        public int Windows { get; set; }

        public House(string color, int flour, int size, int windows)
        {
            Flour = flour;
            Color = color;
            Size = size;
            Windows = windows;
        }
        public object Clone()
        {
           return this.MemberwiseClone();
        }
        public object DeepClone()
        {
            House clone1 = new House(Color,Flour,Size,Windows);
            return clone1;
        }
        public override string ToString()
        {
            string result = "Color :" + Color + "\n" +
               "Flour :" + Flour + "\n" +
               "Size :" + Size + "m2" + "\n" +
               "Windows :" + Windows + "\n";
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            House origin = new House("yelow", 2, 120, 10);

            Console.WriteLine(origin);

            House clone = origin.Clone() as House;
            clone.Color = "green";

            Console.WriteLine(origin.DeepClone());

            Console.WriteLine(clone);

            Console.ReadKey();
        }
    }
}
