using System;

namespace Learning
{
    class Triangles
    {
        public int Sides {get; private set; }
        public int SideOneLength { get; private set;}
        public int SideTwoLength { get; private set; }
        public int SideThreeLength {get; private set; }

        public Triangles(int sides, int sideOneLength, int sideTwoLength, int sideThreeLength)
        {
            Sides = sides;
            SideOneLength = sideOneLength;
            SideTwoLength = sideTwoLength;
            SideThreeLength = sideThreeLength;
        }

        public string Pythagorian()
        {
            int mathSquar = 2;
            double pytest1 = Math.Pow(SideOneLength, mathSquar) + Math.Pow(SideTwoLength, mathSquar);
            double pytest2 = Math.Pow(SideTwoLength, mathSquar) + Math.Pow(SideThreeLength, mathSquar);
            double pytest3 = Math.Pow(SideOneLength, mathSquar) + Math.Pow(SideThreeLength, mathSquar);

            if(pytest1 == Math.Pow(SideThreeLength, mathSquar) || pytest2 == Math.Pow(SideThreeLength, mathSquar)
            || pytest3 == Math.Pow(SideTwoLength, mathSquar))
            {
                return "You have a right triangle!";
            }
            else 
            {
                return "Not a right triangle, bummer dude. ";
            }
            
        }
    }

}