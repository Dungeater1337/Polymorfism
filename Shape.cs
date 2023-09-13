using System;
using System.Collections.Generic;

class Shape
{
    protected double width;
    protected double height;

    public Shape(double width, double height)
    {
        this.width = width;
        this.height = height;
    }
    public virtual double Area()
    {
        return 0;
    }

    public virtual double Circumference()
    {
        return 0;
    }
}