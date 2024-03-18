using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Q4_
{
    class Shape
    {
        public string ShapeType { get; protected set; }
        public double Area { get; protected set; }

        public virtual void CalculateArea()
        {
            // Default implementation does nothing
        }

        public virtual void DisplayShapeInfo()
        {
            Console.WriteLine($"Shape Type: {ShapeType}");
            Console.WriteLine($"Area: {Area}");
        }

        public Shape()
        {
            ShapeType = "Undefined";
            Area = 0;
        }
    }

    class Rectangle : Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            ShapeType = "Rectangle";
            SetDimensions(length, width);
            CalculateArea();
        }

        public void SetDimensions(double length, double width)
        {
            this.length = length;
            this.width = width;
            CalculateArea();
        }

        public override void CalculateArea()
        {
            Area = length * width;
        }
    }

    class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            ShapeType = "Circle";
            SetRadius(radius);
            CalculateArea();
        }

        public void SetRadius(double radius)
        {
            this.radius = radius;
            CalculateArea();
        }

        public override void CalculateArea()
        {
            Area = Math.PI * radius * radius;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //a
            // Create an instance of Rectangle class representing a rectangle with length 5 and width 3
            Rectangle rectangle = new Rectangle(5, 3);


            //b
            // Display shape information for the rectangle
            Console.WriteLine("Rectangle Information:");
            rectangle.DisplayShapeInfo();

            //c
            // Create an instance of Circle class representing a circle with radius 4
            Circle circle = new Circle(4);

            //d
            // Display shape information for the circle
            Console.WriteLine("Circle Information:");
            circle.DisplayShapeInfo();
        }
    }
}