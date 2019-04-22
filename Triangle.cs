using System;

namespace TriangleChecker 
{
    class Triangle 
    {
        private int SideOne;
        private int SideTwo;
        private int SideThree;

        public Triangle(int sideOne, int sideTwo, int sideThree)
        {
            SideOne = sideOne;
            SideTwo = sideTwo;
            SideThree = sideThree;
        }
        public string DetermineType(int sideOne, int sideTwo, int sideThree)
        {
            SideOne = sideOne;
            SideTwo = sideTwo;
            SideThree = sideThree;
            //Check if equilateral
            if (SideOne == SideTwo && SideTwo == SideThree)
            {
                return "an Equilateral triangle";
            }
            else if (SideOne == SideTwo || SideOne == SideThree || SideTwo == SideThree)
            {
                return "an Isosceles triangle";
            }
            else 
            {
                if (SideOne + SideTwo <= SideThree || SideOne + SideThree <= SideTwo || SideTwo + SideThree <= SideOne)
                {
                    return "a Scalene triangle";
                }
                else
                {
                    return "not a triangle.";
                }
            }
        }
    }
}