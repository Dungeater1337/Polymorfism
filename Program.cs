using System;
using System.Collections.Generic;
class Program
{
    static void Main(String[] args)
    {

        Console.WriteLine("Ange höjden: ");
        double height = double.Parse(Console.ReadLine());

        Console.WriteLine("Ange bredden: ");
        double width = double.Parse(Console.ReadLine());

        Console.WriteLine("Skriv in 'T' för triangel, eller 'R' för en rektangel");
        char choice = Console.ReadKey().KeyChar;
        Shape s = null;

        if (choice == 'T' || choice == 't')
        {
            s = new Triangle(width, height);
            double Area = s.Area();
            double Circumference = s.Circumference();

            Console.WriteLine("\nTriangelns area är: " + Area + " a.e " + " Dess omkrets är: " + Circumference + " a.e ");
        }

        else if (choice == 'R' || choice == 'r')
        {
            s = new Rectangle(width, height);
            double Area = s.Area();
            double Circumference = s.Circumference();

            Console.WriteLine("\nRektangelns area är: " + Area + " a.e " + " Dess omkrets är: " + Circumference + " a.e ");
        }
    }
}