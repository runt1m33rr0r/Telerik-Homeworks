namespace Methods.Geometry
{
    using System;
    using GlobalConstants;

    internal class GeometryOperations
    {
        internal static double CalculateTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException(ErrorMessages.InvalidElements);
            }

            double perimeter = a + b + c;
            double halfPerimeter = perimeter / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));

            return area;
        }

        internal static double CalculateDistance(
            double x1, 
            double y1,
            double x2,
            double y2,
            out bool isHorizontal, 
            out bool isVertical)
        {
            isHorizontal = y1 == y2;
            isVertical = x1 == x2;

            double xDeltaSquared = (x2 - x1) * (x2 - x1);
            double yDeltaSquared = (y2 - y1) * (y2 - y1);
            double distance = Math.Sqrt(xDeltaSquared + yDeltaSquared);

            return distance;
        }
    }
}
