using System;

public static class Validator
{
    public static void ValidateIfNegative(int valueToValidate, string valueName)
    {
        if (valueToValidate < 0)
        {
            string negativeNumberMessage = string.Format("{0} cannot be negative number!", valueName);
            throw new ArgumentOutOfRangeException(negativeNumberMessage);
        }
    }

    public static void ValidateIfLessOrEqualTo(int firstValue, int secondValue, string valueName)
    {
        if (firstValue <= secondValue)
        {
            string lessOrEqualMessage = string.Format(
                "{0} cannot be less or equal to {1}!",
                valueName,
                secondValue);
            throw new ArgumentOutOfRangeException(lessOrEqualMessage);
        }
    }

    public static void ValidateIfGreaterThan(int firstValue, int secondValue, string valueName)
    {
        if (firstValue > secondValue)
        {
            string greaterThanNumberMessage = string.Format(
                "{0} cannot be greater than {1}!",
                valueName,
                secondValue);
            throw new ArgumentOutOfRangeException(greaterThanNumberMessage);
        }
    }

    public static void ValidateNullOrEmptyString(string comments, string valueName)
    {
        if (string.IsNullOrEmpty(comments))
        {
            string nullOrEmptyStringMessage = string.Format(
                "{0} cannot be null or empty string!",
                valueName);
            throw new ArgumentNullException(nullOrEmptyStringMessage);
        }
    }

    public static void ValidateNull(object value, string valueName)
    {
        if (value == null)
        {
            string nullValueMessage = string.Format("{0} cannot be null!", valueName);
            throw new ArgumentNullException(nullValueMessage);
        }
    }

    public static void IsInRange(int value, int minRange, int maxRange, string valueName)
    {
        if (value < minRange || value > maxRange)
        {
            string notInRangeMessage = string.Format(
                "{0} must be between {1} and {2}!",
                valueName,
                minRange,
                maxRange);
            throw new ArgumentOutOfRangeException(notInRangeMessage);
        }
    }
}