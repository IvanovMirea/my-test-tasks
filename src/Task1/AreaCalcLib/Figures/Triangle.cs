using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AreaCalcLib.Figures;

public class Triangle : IFigure
{   
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }
    public Triangle(double a, double b, double c)
    {
        if (a < 0 || b < 0 || c < 0)
            throw new ArgumentOutOfRangeException("Sides of triangle can't be less than zero !");
        A = a;
        B = b;
        C = c;
        
    }
    public bool IsTriangleRectangular()
    {
        var bigestOne = new[] { A, B, C }.Max();
        var doubleC = bigestOne * bigestOne;
        if (doubleC + doubleC == A * A + B * B + C * C)
        {
            return true;
        }
        return false;
    }
    public double CalcArea()
    {
        double p = (A + B + C) / 2;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }
}
