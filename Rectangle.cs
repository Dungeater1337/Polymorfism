using System;
using System.Collections.Generic;

class Rectangle : Shape
{
    public Rectangle(double width, double height) : base(width, height)
    {

    }

    public override double Area()
    {
        double Area = width * height;

        return Area;
    }

    public override double Circumference()
    {
        double Circumference = 2 * (width + height);

        return Circumference;
    }
}