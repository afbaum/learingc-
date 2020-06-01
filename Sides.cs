namespace Learning
{
    class Sides
    {
        public int NumberOfSides {get; private set; }

        public string ShapeName {get; private set; }

        public Sides (int numberOfsides)
        {
            NumberOfSides = numberOfsides;
        }

        public string ReturnShape()
        {
            if(NumberOfSides <= 2 )
            {
                return "Try again";
            }
            else if(NumberOfSides == 3)
            {
                ShapeName = "Triangle";
            }
            else if(NumberOfSides == 4)
            {
                ShapeName = "Quadralateral";
            }
            else if(NumberOfSides == 5)
            {
                ShapeName = "Pentagon";
            }
            else if(NumberOfSides == 6)
            {
                ShapeName = "Hexigon";
            }
            else if(NumberOfSides == 7)
            {
                ShapeName = "Heptagon";
            }
            else if(NumberOfSides == 8)
            {
                ShapeName = "Octagon";
            }
            else if(NumberOfSides == 9)
            {
                ShapeName = "Nonagon";
            }
            else if(NumberOfSides == 10)
            {
                ShapeName =  "Decagon";
            }    
            else
            {
                return "Try again";
            }
            return "Your shape is a " + ShapeName;                                            
        }
    }

}