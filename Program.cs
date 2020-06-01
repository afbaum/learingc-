using System;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            int SidesNumber = 8;
            Sides sides = new Sides(SidesNumber);
            Console.WriteLine(sides.ReturnShape());
            for(int i = 0; i < SidesNumber; i++)
            {
                Console.WriteLine("What is the length of side " + i + "?");
                Console.ReadLine();
                // put the readline numbers into an array or list
            }
            // Triangles triangle = new Triangles(3,6.5,9.4,14.5);
            // Console.WriteLine(triangle.Pythagorian());
            // Console.WriteLine(triangle.LawOfCosin());

            // Square square = new Square(4,6);
            // Console.WriteLine(square.Area());
            // Console.WriteLine(square.Parimeter());
            // Console.WriteLine(square.Diagonal());
        }
    }
}
