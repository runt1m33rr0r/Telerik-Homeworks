namespace _3DSpace
{
    using System.Collections.Generic;

    public class Path
    {
        public Path(List<Point3D> points)
        {
            this.PtSequence = points;
        }

        public Path(Point3D[] points)
        {
            this.PtSequence = new List<Point3D>(points);
        }

        public List<Point3D> PtSequence { get; private set; }

        public Point3D this[int index]
        {
            get
            {
                return this.PtSequence[index];
            }

            set
            {
                this.PtSequence[index] = value;
            }
        }

        public void AddPoint(Point3D somePoint)
        {
            this.PtSequence.Add(somePoint);
        }

        public void RemovePoint(Point3D somePoint)
        {
            this.PtSequence.Remove(somePoint);
        }

        public void ClearPath()
        {
            this.PtSequence.Clear();
        }
    }
}
