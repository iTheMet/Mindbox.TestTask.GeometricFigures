namespace GeometricFigures
{
    internal class Triangle : ITriangle
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }


        public Triangle(double a, double b, double c)
        {
            A = a; B = b; C = c; 
        }

        public double GetArea()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p*(p-A)*(p-B)*(p-C));
        }

        public bool IsRightAngled()
        {
            throw new NotImplementedException();
        }
    }
}
