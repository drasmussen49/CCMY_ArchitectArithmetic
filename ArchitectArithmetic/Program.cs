using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Architect Arithmetic program!");
            Console.WriteLine("To see the estimated area and cost for Teotihuacan in Mexico, type 1");
            Console.WriteLine("To see the estimated area and cost for the Taj Mahal in India, type 2");
            Console.WriteLine("To see the estimated area and cost for the Great Mosque of Mecca, type 3");
            int userInput = Convert.ToInt32(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    EstimateTotalCostTeotihuacan();
                    break;
                case 2:
                    EstimateTotalCostTajMahal();
                    break;
                case 3:
                    EstimateTotalCostMecca();
                    break;
                default:
                    Console.WriteLine("You didn't choose appropriately. Press enter to exit program.");
                    break;
            }

            


            Console.ReadLine();
        }
        /*public static double RectangleArea(double recLength, double recWidth)
        {
            return recLength * recWidth;
        }
        public static double CircleArea(double cirRadius)
        {
            return Math.PI * Math.Pow(cirRadius, 2);
        }
        public static double TriangleArea(double triBottom, double triHeight)
        {
            return 0.5 * triBottom * triHeight;
        }*/
        public static void EstimateTotalCostTeotihuacan()
        {
            double recLength = 2500;
            double recWidth = 1500;
            double cirRadius = 187.5;
            double triBottom = 750;
            double triHeight = 500;
            double recArea = recLength * recWidth;
            double cirArea = Math.PI * Math.Pow(cirRadius, 2);
            double triArea = (0.5 * triBottom) * triHeight;
            double totalArea = recArea + cirArea + triArea;
            double matCost = 180 * totalArea;
            matCost = Math.Round(matCost, 2);
            Console.WriteLine($"For a total area of {totalArea} meters squared, the estimated constuction cost of Teotihuacan in pesos is {matCost}.");
        }
        public static void EstimateTotalCostTajMahal()
        {
            double recLength = 90.5;
            double recWidth = 90.5;
            double cirRadius = 0;
            double triBottom = 24;
            double triHeight = 24;
            double recArea = recLength * recWidth;
            double cirArea = Math.PI * Math.Pow(cirRadius, 2);
            double triArea = (0.5 * triBottom) * triHeight;
            double totalArea = recArea + cirArea - (4 * triArea);
            double matCost = 180 * totalArea;
            matCost = Math.Round(matCost, 2);
            Console.WriteLine($"For a total area of {totalArea} meters squared, the estimated constuction cost of the Taj Mahal in pesos is {matCost}.");
        }
        public static void EstimateTotalCostMecca()
        {
            double recLength = 284;
            double recWidth = 264;
            double secondRecLength = 180;
            double secondRecWidth = 106;
            double cirRadius = 0;
            double triBottom = 264;
            double triHeight = 84;
            double recArea = recLength * recWidth;
            double secondRecArea = secondRecLength * secondRecWidth;
            double cirArea = Math.PI * Math.Pow(cirRadius, 2);
            double triArea = (0.5 * triBottom) * triHeight;
            double totalArea = recArea + secondRecArea + cirArea - triArea;
            double matCost = 180 * totalArea;
            matCost = Math.Round(matCost, 2);
            Console.WriteLine($"For a total area of {totalArea} meters squared, the estimated constuction cost of the Great Mosque of Mecca in pesos is {matCost}.");
        }
    }
}
