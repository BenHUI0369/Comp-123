using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_W6_Lab1
{
    class Ellipse : Rectangle
    {
        public override double Area { get; }
        public Ellipse(string name, double height, double width):base(name, height, width)
        {
            base.Name = name;
            Area = Math.PI * width * height;
        }
    }
}
