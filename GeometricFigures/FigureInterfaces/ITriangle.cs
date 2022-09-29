namespace GeometricFigures
{
    internal interface ITriangle : IFigure
    {
        /// <summary>
        /// Checks whether the triangle is right angled
        /// </summary>
        /// <returns>If triangle is right angled - true, otherwise - false</returns>
        bool IsRightAngled();
    }
}
