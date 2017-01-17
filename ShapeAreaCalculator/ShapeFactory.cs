using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator
{
    public class ShapeFactory
    {
        public Shape GetShape(int shapeTypeOption)
        {
            switch(shapeTypeOption)
            {
                case ShapeTypeConstants.Circle: return new Circle();
                case ShapeTypeConstants.Rectangle: return new Rectangle();
                case ShapeTypeConstants.Triangle: return new Triangle();
                default: throw new Exception("Invalid shape-type option");                  
            }
        }
        public static class ShapeTypeConstants
        {
            public const int Circle = 1;
            public const int Rectangle = 2;
            public const int Triangle = 3;
        }
    }
}
