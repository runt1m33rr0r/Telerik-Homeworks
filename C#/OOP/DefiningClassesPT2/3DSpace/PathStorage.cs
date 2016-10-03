namespace _3DSpace
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public static class PathStorage
    {
        // path text format: X,Y,Z|X,Y,Z|X,Y,Z
        public static Path[] GetPathsFromFile(string fileLocation)
        {
            List<Path> result = new List<Path>();
            string[] paths = File.ReadAllLines(fileLocation);

            foreach (var path in paths)
            {
                List<Point3D> points = new List<Point3D>();
                string[] pointsFromFile = path.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var point in pointsFromFile)
                {
                    string[] coords = point.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    Point3D currentPoint = new Point3D(double.Parse(coords[0]), double.Parse(coords[1]), double.Parse(coords[2]));

                    points.Add(currentPoint);
                }

                result.Add(new Path(points));
            }

            return result.ToArray();
        }
    }
}
