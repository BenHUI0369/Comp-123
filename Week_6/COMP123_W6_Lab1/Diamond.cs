using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_W6_Lab1
{
    class Diamond : Rectangle
    {
        public override double Area { get; }
        public Diamond(string name, double height, double width):base(name, height, width)
        {
            Area = width * height * 0.5;
        }
    }
}
