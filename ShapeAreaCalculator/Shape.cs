using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator
{
    public abstract class Shape
    {
        private double area;
        public double Area
        {
            get { return area; }
            set { area = value; }
        }
        public abstract Shape CalculateArea(params double[] dimensions);
        public abstract void Display();
    }
}
