using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_W6_Lab1
{
    class Circle : Square
    {
        public override double Area { get; }
        public Circle(string name, double length):base(name,length)
        {
            Area = Math.PI * length * length;
            base.Name = name;
        }
    }
}
