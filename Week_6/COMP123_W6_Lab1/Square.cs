using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_W6_Lab1
{
    class Square : Shape
    {
        static double Length { get; set; }
        public override double Area { get; }
        public Square(string name, double length):base(name)
        {
            Length = length;
            Area = Length * Length;
            base.Name = name;
        }
    }
}
