using System;
using System.Collections.Generic;

class Triangle : Shape
{
    public Triangle(double width, double height) : base(width, height)
    {

    }

    public override double Area()
    {
        double Area = width * height / 2;

        return Area;
    }

    public override double Circumference()
    {
        double Squared1 = width * width;
        double Squared2 = height * height;

        double hypo = Math.Sqrt(Squared1 + Squared2);

        double Circumference = width + height + hypo;
        return Circumference;
    }
}