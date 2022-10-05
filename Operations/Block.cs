using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    internal class Block
    {
        int Side1 { get; set; }
        int Side2 { get; set; }
        int Side3 { get; set; }
        int Side4 { get; set; }
        string Name { get; set; }

        public Block(string name, int side1, int side2, int side3, int side4)
        {
            
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
            Side4 = side4;
            Name = name;
        }
        public override bool Equals(object obj)
        {
            Block comparison = obj as Block;
            if (comparison == null) return false;
            if (this.Side1 + Side2 + Side3 + Side4 != comparison.Side1 + Side2 + Side3 + Side4) return true;
            return false;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
       

        
   
    
