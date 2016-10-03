namespace _3DSpace
{
    public class Test
    {
        // text format: X,Y,Z|X,Y,Z|X,Y,Z
        public static void Main()
        {
            Path[] pathsFromFile = PathStorage.GetPathsFromFile("someFile");

            foreach (var path in pathsFromFile)
            {
                foreach (var point in path.PtSequence)
                {
                    System.Console.WriteLine(point.ToString());
                }
            }
        }
    }
}
