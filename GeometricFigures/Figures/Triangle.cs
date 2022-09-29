namespace GeometricFigures
{
    public class Triangle : ITriangle
    {
        /// <summary>
        /// Array of triangle side lengths
        /// </summary>
        public double[] Sides { get;}

        /// <summary>
        /// Initialize a new instance of Triangle class
        /// </summary>
        /// <param name="firstSide">First side length of triangle</param>
        /// <param name="secondSide">Second side length of triangle</param>
        /// <param name="thirdSide">Third side length of triangle</param>
        /// <exception cref="ArgumentException">
        /// None of the sides of a triangle can be less than or equal to zero, 
        /// and also can't be greater than the sum of the other two sides
        /// </exception>
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            //If any side of the triangle is equal to or less than zero...
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
            {
                //Throw exception
                throw new ArgumentException("None of the sides of a triangle can be less than or equal to zero.");
            }
            //If any side of the triangle greater than sum of the other two...
            if (firstSide + secondSide < thirdSide || secondSide + thirdSide < firstSide || firstSide + thirdSide < secondSide)
            {
                //Throw exception
                throw new ArgumentException("None of the sides of a triangle can be greater than the sum of the other two sides.");
            }
            //Array of triangle side lengths assign parameter values
            Sides = new double[] { firstSide, secondSide, thirdSide };
        }

        /// <summary>
        /// Calculates the area of a triangle by 3 sides
        /// </summary>
        /// <returns>The area of a triangle</returns>
        public double GetArea()
        {
            //Initializes a new variable equal to the half-perimeter of the triangle
            double hPetimeter = (Sides[0] + Sides[1] + Sides[2]) / 2;
            //Initializes a new variable equal to the area of the triangle
            double area = hPetimeter * (hPetimeter - Sides[0]) * (hPetimeter - Sides[1]) * (hPetimeter - Sides[2]);
            //Return area
            return Math.Sqrt(area);
        }

        /// <summary>
        /// Checks whether the triangle is right angled
        /// </summary>
        /// <returns>If triangle is right angled - true, otherwise - false</returns>
        public bool IsRightAngled()
        {
            //Sort array of sides by value ascend
            Array.Sort(Sides);
            //Returns a boolean value by the expression is the square of
            //the hypotenuse equal to the sum of the squares of the legs
            return Math.Pow(Sides[2], 2) == (Math.Pow(Sides[0], 2) + Math.Pow(Sides[1], 2));
        }
    }
}
