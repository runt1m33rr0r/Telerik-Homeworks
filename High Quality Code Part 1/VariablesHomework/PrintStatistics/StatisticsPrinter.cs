namespace PrintStatistics
{
    using System;

    public class StatisticsPrinter
    {
        public void PrintStatistics(double[] numbersArray, int elementsCount)
        {
            double maxNumber = this.GetMaxNumber(numbersArray, elementsCount);
            double minNumber = this.GetMinNumber(numbersArray, elementsCount);
            double averageNumber = this.GetAverageNumber(numbersArray, elementsCount);

            this.PrintNumber(maxNumber);
            this.PrintNumber(minNumber);
            this.PrintNumber(averageNumber);
        }

        private void PrintNumber(double number)
        {
            Console.WriteLine(number);
        }

        private double GetMaxNumber(double[] numbersArray, int elementsCount)
        {
            double maxNumber = double.MinValue;

            for (int i = 0; i < elementsCount; i++)
            {
                double currentNumber = numbersArray[i];

                if (currentNumber > maxNumber)
                {
                    maxNumber = currentNumber;
                }
            }

            return maxNumber;
        }

        private double GetMinNumber(double[] numbersArray, int elementsCount)
        {
            double minNumber = double.MaxValue;

            for (int i = 0; i < elementsCount; i++)
            {
                double currentNumber = numbersArray[i];

                if (currentNumber < minNumber)
                {
                    minNumber = currentNumber;
                }
            }

            return minNumber;
        }

        private double GetAverageNumber(double[] numbersArray, int elementsCount)
        {
            double sumOfNumbers = 0;

            for (int i = 0; i < elementsCount; i++)
            {
                double currentNumber = numbersArray[i];

                sumOfNumbers += currentNumber;
            }

            double averageNumber = sumOfNumbers / elementsCount;

            return averageNumber;
        }
    }
}
