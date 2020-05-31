using System;

namespace Learning
{
    class Square
    {
        public int Sides { get; private set;}
        public int SideOneLength { get; private set;}

        public Square(int sides, int sideLength)
        {
            Sides = sides;
            SideOneLength = sideLength;
        }

        public string Area()
        {
            int area = SideOneLength * SideOneLength;
            return "The area of your square is " + area;
        }

        public string Parimeter()
        {
            int parimeter = SideOneLength * 4;
            return "The parimeter of your square is " + parimeter;
        }

        public string Diagonal()
        {
            double diagonal = SideOneLength * Math.Sqrt(2);
            return "The diagonal of your square is " + diagonal;
        }
    }
}