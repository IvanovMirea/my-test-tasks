using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalcLib.Figures;

public class Circle : IFigure
{
    public double R { get; }
    public Circle(double r)
    {
        if (r < 0)
            throw new ArgumentOutOfRangeException("Radius can't be less than zero !");
        R = r;
    }
    public double CalcArea()
    {
        return Math.PI * R * R;
    }

}
