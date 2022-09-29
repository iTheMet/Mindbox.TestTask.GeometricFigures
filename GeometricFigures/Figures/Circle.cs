namespace GeometricFigures
{
    public class Circle : ICircle
    {
        /// <summary>
        /// Radius of the circle
        /// </summary>
        public double Radius { get;}

        /// <summary>
        /// Initializes a new instance of Circle class
        /// </summary>
        /// <param name="radius">Radius of the circle</param>
        /// <exception cref="ArgumentException">
        /// The radius of the circle cannot be less than or equal to zero
        /// </exception>
        public Circle(double radius)
        {
            //If radius of the circle greater than zero...
            if (radius > 0)
                //The radius is assigned the value of the parameter
                Radius = radius;
            //Otherwise, throw exception
            else throw new ArgumentException("The radius of the circle cannot be less than or equal to zero.");
        }

        /// <summary>
        /// Calculates the area of the circle by radius
        /// </summary>
        /// <returns>The area of the circle</returns>
        public double GetArea()
        {
            //Returns the area of the circle by πR^2 formula
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
