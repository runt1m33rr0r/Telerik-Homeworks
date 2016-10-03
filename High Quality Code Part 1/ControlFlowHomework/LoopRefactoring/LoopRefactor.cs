namespace LoopRefactoring
{
    using System;
    using System.Text;

    internal class LoopRefactor
    {
        public static void SearchForValue(int[] arrayForSearch, int expectedInteger)
        {
            bool isFound = false;
            StringBuilder loopResult = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                int currentElement = arrayForSearch[i];

                if (currentElement == expectedInteger && i % 10 == 0)
                {
                    isFound = true;

                    break;
                }

                loopResult.AppendLine(currentElement.ToString());
            }

            if (isFound)
            {
                loopResult.AppendLine("Value Found");
            }

            Console.WriteLine(loopResult);
        }
    }
}
