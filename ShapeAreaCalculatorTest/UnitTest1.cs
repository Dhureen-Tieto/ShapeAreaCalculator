using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeAreaCalculator;
namespace ShapeAreaCalculatorTest
{
    [TestClass]
    public class ShapeAreaCalculatorTester
    {
        [TestMethod, ExpectedException(typeof(Exception))]
        public void GivingZeroAsTheRadiusWhileCalculatingAreaOfCircleShouldThrowsException()
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            int shapeTypeOption = 1;
            Shape shape = shapeFactory.GetShape(shapeTypeOption);
            var result = shape.CalculateArea(0);
        }
        [TestMethod, ExpectedException(typeof(Exception))]
        public void GivingZeroAsTheLengthOrBreadthWhileCalculatingAreaOfRectangleShouldThrowsException()
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            int shapeTypeOption = 2;
            Shape shape = shapeFactory.GetShape(shapeTypeOption);
            var result = shape.CalculateArea(0, 1);
        }
        [TestMethod, ExpectedException(typeof(Exception))]
        public void GivingZeroAsTheHeightOrBaseWhileCalculatingAreaOfTriangleShouldThrowsException()
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            int shapeTypeOption = 3;
            Shape shape = shapeFactory.GetShape(shapeTypeOption);
            var result = shape.CalculateArea(0, 1);
        }
        [TestMethod, ExpectedException(typeof(Exception))]
        public void GivingTwoInputParametersWhileCalculatingAreaOfCircleShouldThrowsException()
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            int shapeTypeOption = 1;
            Shape shape = shapeFactory.GetShape(shapeTypeOption);
            var result = shape.CalculateArea(0,1);
        }
        [TestMethod, ExpectedException(typeof(Exception))]
        public void GivingOneInputParameterWhileCalculatingAreaOfRectangleShouldThrowsException()
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            int shapeTypeOption = 2;
            Shape shape = shapeFactory.GetShape(shapeTypeOption);
            var result = shape.CalculateArea(1);
        }
        [TestMethod, ExpectedException(typeof(Exception))]
        public void GivingThreeInputParametersWhileCalculatingAreaOfTriangleShouldThrowsException()
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            int shapeTypeOption = 3;
            Shape shape = shapeFactory.GetShape(shapeTypeOption);
            var result = shape.CalculateArea(1,2,3);
        }
        [TestMethod]
        public void GivingTwoAsRadiusWhileCalculatingAreaOfCircleShouldReturnCorrectValue()
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            int shapeTypeOption = 1;
            Shape shape = shapeFactory.GetShape(shapeTypeOption);
            var result = shape.CalculateArea(2);
            Assert.AreEqual(Math.PI * 2 * 2, result.Area, "Result is not correct");
        }
        [TestMethod]
        public void GivingTwoAsLengthAndBreadthsWhileCalculatingAreaOfRectangleShouldReturnCorrectValue()
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            int shapeTypeOption = 2;
            Shape shape = shapeFactory.GetShape(shapeTypeOption);
            var result = shape.CalculateArea(2,2);
            Assert.AreEqual( 2 * 2, result.Area, "Result is not correct");
        }
        [TestMethod]
        public void GivingTwoAsHeightAndBaseWhileCalculatingAreaOfTriangleShouldReturnCorrectValue()
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            int shapeTypeOption = 3;
            Shape shape = shapeFactory.GetShape(shapeTypeOption);
            var result = shape.CalculateArea(2,2);
            Assert.AreEqual(0.5 * 2 * 2, result.Area, "Result is not correct");
        }
        [TestMethod, ExpectedException(typeof(Exception))]
        public void GivingNegativeOneAsTheRadiusWhileCalculatingAreaOfCircleShouldThrowsException()
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            int shapeTypeOption = 1;
            Shape shape = shapeFactory.GetShape(shapeTypeOption);
            var result = shape.CalculateArea(-1);
        }
        [TestMethod, ExpectedException(typeof(Exception))]
        public void GivingNegativeOneAsTheLengthOrBreadthWhileCalculatingAreaOfRectangleShouldThrowsException()
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            int shapeTypeOption = 2;
            Shape shape = shapeFactory.GetShape(shapeTypeOption);
            var result = shape.CalculateArea(-1, 1);
        }
        [TestMethod, ExpectedException(typeof(Exception))]
        public void GivingNegativeOneAsTheHeightOrBaseWhileCalculatingAreaOfTriangleShouldThrowsException()
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            int shapeTypeOption = 3;
            Shape shape = shapeFactory.GetShape(shapeTypeOption);
            var result = shape.CalculateArea(-1, 1);
        }

        [TestMethod]
        public void GivingTwoAsLengthAndThreeAsBreadthsWhileCalculatingAreaOfRectangleShouldReturnCorrectValue()
        {
            ShapeFactory shapeFactory = new ShapeFactory();
            int shapeTypeOption = 2;
            Shape shape = shapeFactory.GetShape(shapeTypeOption);
            var result = shape.CalculateArea(2, 3);
            Assert.AreEqual(2 * 3, result.Area, "Result is not correct");
        }
    }
}
