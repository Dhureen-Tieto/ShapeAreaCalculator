using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator
{
    class Triangle : Shape
    {
       
        public override Shape CalculateArea(double[] dimensions)
        {
            // throw new NotImplementedException();
            if (dimensions.Length != 2)
                throw new Exception("Invalid input:Required two Parameters");
            if (dimensions[0] < 0 || dimensions[1] < 0 )
                throw new Exception("Invalid input:Positive numbers required;Negative passed a input");
            if (dimensions[0] == 0 || dimensions[1] == 0)
                throw new Exception("Invalid input:Height or Base of a Triangle can't be zero");
            Area = 0.5 * dimensions[0] * dimensions[1];
            return this;
        }

        public override void Display()
        {
            // throw new NotImplementedException();
            Console.WriteLine("Area of the Triangle is {0}", Area);
        }
    }
}
