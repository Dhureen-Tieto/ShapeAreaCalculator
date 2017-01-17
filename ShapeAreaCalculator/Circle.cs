using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator
{
    class Circle : Shape
    {
       
        public override Shape CalculateArea(double[] dimensions)
        {
            //throw new NotImplementedException();
            if (dimensions.Length != 1)
                throw new Exception("Invalid input:Required only one Parameter");
            if (dimensions[0] < 0)
                throw new Exception("Invalid input:Positive numbers required;Negative passed a input");
            if (dimensions[0] == 0)
                throw new Exception("Invalid input:Radius of a Circle can't be zero");
            Area = Math.PI * dimensions[0] * dimensions[0];
            return this;
        }      

        public override  void Display()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Area of the Circle is {0}", Area);
        }
    }
}
