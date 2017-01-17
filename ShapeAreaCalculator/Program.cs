using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {           
            while (true)
            {

                string displayText = "Enter choice:\n1.Circle\n2.Rectangle\n3.Triangle\n4.Exit\n";
                Console.WriteLine(displayText);
                string inputChoice = Console.ReadLine();
                if (inputChoice == "exit")
                {
                    break;
                }
                Shape shape = ConstructAShape(inputChoice);
                List<double> dimensions = new List<double>();
                dimensions = GetShapeDimensions(int.Parse(inputChoice));                
                shape.CalculateArea(dimensions).Display();
            }
        }

        private static List<double> GetShapeDimensions(int shapeTypeOption)
        {
            //throw new NotImplementedException();
            List<double> dimensions = new List<double>();
            string[] auxDimensions = {"",""};
            switch (shapeTypeOption)
            {
                case ShapeFactory.ShapeTypeConstants.Circle:
                    Console.WriteLine("Enter radius");
                    dimensions.Add(double.Parse(Console.ReadLine().Trim()));
                    break;
                case ShapeFactory.ShapeTypeConstants.Rectangle:
                    Console.WriteLine("Enter Length and Breadth");
                    auxDimensions = GetDimensionsAsArray(dimensions);
                    break;
                case ShapeFactory.ShapeTypeConstants.Triangle:
                    Console.WriteLine("Enter Height and Base");
                    auxDimensions = GetDimensionsAsArray(dimensions);
                    break;
                
            }

            return dimensions ;
        }

        private static string[] GetDimensionsAsArray(List<double> dimensions)
        {
            string[] auxDimensions = Console.ReadLine().Trim().Split(',');
            dimensions.Add(double.Parse(auxDimensions[0]));
            dimensions.Add(double.Parse(auxDimensions[1]));
            return auxDimensions;
        }

        private static Shape ConstructAShape(string line)
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            int shapeTypeOption = int.Parse(line);
            Shape shape = shapeFactory.GetShape(shapeTypeOption);
            return shape;
        }
    }
}
