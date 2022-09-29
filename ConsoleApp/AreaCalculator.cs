using GeometricFigures;

namespace ConsoleApp
{
    internal static class AreaCalculator
    {
        public static double Calc(IFigure figure)
        {            
            return figure.GetArea();
        }
    }
}
