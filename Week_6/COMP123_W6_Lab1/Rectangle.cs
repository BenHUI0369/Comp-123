using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_W6_Lab1
{
    class Rectangle : Shape
    {
        static double Width { get; set; }
        static double Height { get; set; }
        public override double Area { get;}   
        public Rectangle(string name, double height, double width):base(name)
        {
            Width = width;
            Height = height;
            Area = Width * Height;
            base.Name = name;
        }
    }
}
