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
                shape.CalculateArea(GetShapeDimensions(int.Parse(inputChoice))).Display();
            }
        }

        private static double[] GetShapeDimensions(int shapeTypeOption)
        {
            //throw new NotImplementedException();
            double[] dimensions;
            switch (shapeTypeOption)
            {
                case ShapeFactory.ShapeTypeConstants.Circle: Console.WriteLine("Enter radius");
                    
                    break; 
                case ShapeFactory.ShapeTypeConstants.Rectangle: Console.WriteLine("Enter Length and Breadth");
                    
                    break;
                case ShapeFactory.ShapeTypeConstants.Triangle: Console.WriteLine("Enter Height and Base");
                    
                    break;
                
            }
            dimensions = Array.ConvertAll(Console.ReadLine().Split(' '), Double.Parse);
            return dimensions ;
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
