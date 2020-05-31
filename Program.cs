using System;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangles triangle = new Triangles(3,3,4,5);
            Console.WriteLine(triangle.Pythagorian());

            Square square = new Square(4,6);
            Console.WriteLine(square.Area());
            Console.WriteLine(square.Parimeter());
            Console.WriteLine(square.Diagonal());
        }
    }
}
