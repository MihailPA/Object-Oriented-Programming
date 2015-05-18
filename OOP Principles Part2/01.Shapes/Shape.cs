//Problem 1. Shapes
//Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
//Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure (height * width for rectangle and height * width/2 for triangle).
//Define class Square and suitable constructor so that at initialization height must be kept equal to width and implement the CalculateSurface() method.
//Write a program that tests the behaviour of the CalculateSurface() method for different shapes (Square, Rectangle, Triangle) stored in an array.


using System;

namespace _01.Shapes
{
    using System;

    // Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
    abstract class Shape
    {
        private double width;
        private double height;

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (CheckValue(value))
                {
                    this.width = value;
                }
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (CheckValue(value))
                {
                    this.height = value;
                }
            }
        }

        private bool CheckValue(double value)
        {
            if (value < 1)
            {
                throw new ArgumentOutOfRangeException("Width and Hight must be positive numbers");
            }

            return true;
        }

        // the method has empty body, it will be mandatory implemented by the "kids" of shape
        public abstract double CalculateSurface();
    }
}
