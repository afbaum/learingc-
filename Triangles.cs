using System;

namespace Learning
{
    class Triangles
    {
        public int Sides {get; private set; }
        public double SideOneLength { get; private set;}
        public double SideTwoLength { get; private set; }
        public double SideThreeLength {get; private set; }

        public Triangles(int sides, double sideOneLength, double sideTwoLength, double sideThreeLength)
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

        public string LawOfCosin()
        {
            int mathSquar = 2;
            double angle1 = (180 / Math.PI) * Math.Acos((Math.Pow(SideTwoLength, mathSquar) + 
                            Math.Pow(SideThreeLength, mathSquar) - 
                            Math.Pow(SideOneLength, mathSquar)) / (2 * SideTwoLength * SideThreeLength));
            double angle2 = (180 / Math.PI) * Math.Acos((Math.Pow(SideOneLength, mathSquar) + 
                            Math.Pow(SideThreeLength, mathSquar) - 
                            Math.Pow(SideTwoLength, mathSquar)) / (2 * SideOneLength * SideThreeLength));
            double angle3 = (180 / Math.PI) * Math.Acos((Math.Pow(SideOneLength, mathSquar) + 
                            Math.Pow(SideTwoLength, mathSquar) - 
                            Math.Pow(SideThreeLength, mathSquar)) / (2 * SideOneLength * SideTwoLength));
            angle1 = Math.Round(angle1, MidpointRounding.AwayFromZero);
            angle2 = Math.Round(angle2, MidpointRounding.AwayFromZero);
            angle3 = Math.Round(angle3, MidpointRounding.AwayFromZero);
            return "The angles of your triange are " + angle1 + ", " + angle2 + ", " + angle3; 
        }
    }

}