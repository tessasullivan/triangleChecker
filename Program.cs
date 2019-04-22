using System;

namespace TriangleChecker
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter side one length");
            string stringSideOne = Console.ReadLine();
            int sideOne = int.Parse(stringSideOne);

            Console.WriteLine("Enter side two length");
            string stringSideTwo = Console.ReadLine();
            int sideTwo = int.Parse(stringSideTwo);

            Console.WriteLine("Enter side three length");
            string stringSideThree = Console.ReadLine();
            int sideThree = int.Parse(stringSideThree);

            Triangle triangleToCheck = new Triangle(sideOne, sideTwo, sideThree);
             
            System.Console.WriteLine("This is " + triangleToCheck.DetermineType(sideOne, sideTwo, sideThree));
        }
    }
}