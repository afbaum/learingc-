using System;

namespace Learning
{
    class Triangles
    {
        public int Sides;
        public int SideOneLength;
        public int SideTwoLength;
        public int SideThreeLength;

        public Triangles(int sides, int sideOneLength, int sideTwoLength, int sideThreeLength)
        {
            Sides = sides;
            SideOneLength = sideOneLength;
            SideTwoLength = sideTwoLength;
            SideThreeLength = sideThreeLength;
        }
    }

}