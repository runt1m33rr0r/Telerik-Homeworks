namespace Abstraction.Common
{
    using System;
    using GlobalConstants;

    public static class Validator
    {
        public static void ValidateIfDoubleIsPositive(double value, string propertyName)
        {
            if (value <= 0)
            {
                throw new ArgumentException(string.Format(ErrorMessages.NegativeDouble, propertyName));
            }
        }
    }
}
