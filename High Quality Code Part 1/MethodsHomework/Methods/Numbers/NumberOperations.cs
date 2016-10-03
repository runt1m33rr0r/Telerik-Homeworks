namespace Methods.Numbers
{
    using System;
    using GlobalConstants;

    internal class NumberOperations
    {
        internal static string NumberToDigit(int number)
        {
            switch (number)
            {
                case 0: return BasicStrings.Zero;
                case 1: return BasicStrings.One;
                case 2: return BasicStrings.Two;
                case 3: return BasicStrings.Three;
                case 4: return BasicStrings.Four;
                case 5: return BasicStrings.Five;
                case 6: return BasicStrings.Six;
                case 7: return BasicStrings.Seven;
                case 8: return BasicStrings.Eight;
                case 9: return BasicStrings.Nine;
                default: throw new ArgumentException(ErrorMessages.InvalidNumber);
            }
        }

        internal static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException(ErrorMessages.InvalidElements);
            }

            int biggestElement = int.MinValue;

            for (int i = 1; i < elements.Length; i++)
            {
                int currentElement = elements[i];

                if (currentElement > biggestElement)
                {
                    biggestElement = currentElement;
                }
            }

            return biggestElement;
        }
    }
}
