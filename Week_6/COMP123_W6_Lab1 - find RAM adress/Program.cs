namespace COMP123_W6_Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //although Shape is an abstract is can be used as a reference type
            //any child class of Shape is also a Shape
            List<Shape> shapes = new List<Shape>();

            shapes.Add(new Square("s1", 2));

            shapes.Add(new Rectangle("r1", 2, 3));
            shapes.Add(new Circle("c1", 2));
            shapes.Add(new Triangle("t1", 4, 6));
            shapes.Add(new Ellipse("e1", 2, 3));
            shapes.Add(new Diamond("d1", 2, 3));

            shapes.Add(new Square("s2", 5));
            shapes.Add(new Rectangle("r2", 5, 4));
            shapes.Add(new Circle("c2", 1));
            shapes.Add(new Triangle("t2", 7, 8));

            foreach (var s in shapes)
            {
                Console.WriteLine(s);
            }
        }
    }
}