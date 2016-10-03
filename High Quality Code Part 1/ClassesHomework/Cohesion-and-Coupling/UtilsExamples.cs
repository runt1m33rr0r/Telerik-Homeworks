namespace CohesionAndCoupling
{
    using System;

    public class UtilsExamples
    {
        private static void Main()
        {
            Console.WriteLine(FileUtils.GetFileExtension("example"));
            Console.WriteLine(FileUtils.GetFileExtension("example.pdf"));
            Console.WriteLine(FileUtils.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine(
                "Distance in the 2D space = {0:f2}",
                FigureUtils.CalcDistance2D(1, -2, 3, 4));

            Console.WriteLine(
                "Distance in the 3D space = {0:f2}",
                FigureUtils.CalcDistance3D(5, 2, -1, 3, -6, 4));

            var figure = new Figure(3, 4, 5);

            Console.WriteLine("Volume = {0:f2}", FigureUtils.CalcVolume(figure));
            Console.WriteLine("Diagonal XYZ = {0:f2}", FigureUtils.CalcDiagonalXYZ(figure));
            Console.WriteLine("Diagonal XY = {0:f2}", FigureUtils.CalcDiagonalXY(figure));
            Console.WriteLine("Diagonal XZ = {0:f2}", FigureUtils.CalcDiagonalXZ(figure));
            Console.WriteLine("Diagonal YZ = {0:f2}", FigureUtils.CalcDiagonalYZ(figure));
        }
    }
}