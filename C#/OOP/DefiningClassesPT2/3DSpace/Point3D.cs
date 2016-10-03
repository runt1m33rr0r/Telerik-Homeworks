namespace _3DSpace
{
    public struct Point3D
    {
        private static readonly Point3D StartCoordinates = new Point3D(0.0, 0.0, 0.0);

        public Point3D(double xCoord, double yCoord, double zCoord)
        {
            this.X = xCoord;
            this.Y = yCoord;
            this.Z = zCoord;
        }

        public static Point3D StartCoords { get; }

        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        public override string ToString()
        {
            return string.Format("[{0}, {1}, {2}]", this.X, this.Y, this.Z);
        }
    }
}
