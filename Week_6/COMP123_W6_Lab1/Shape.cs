using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_W6_Lab1
{
    abstract class Shape
    {
        public string Name { get; protected set; }
        public abstract double Area { get; }
        public Shape(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            return $"Name:{Name,3:f2} Area:{Area,6:f2}m²";
        }
    }
}
