using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifePath.Common
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Returns the absolute value of a number.
        /// </summary>
        /// <param name="number">The number to compute.</param>
        /// <returns>A positive integer.</returns>
        public static int Absolute(this int number)
        {
            if (number < 0)
            {
                return number * -1;
            }
            else
            {
                return number;
            }
        }

        /// <summary>
        /// Returns the ordinal number.
        /// </summary>
        /// <param name="number">The number to produce the ordinal number from.</param>
        /// <returns>An ordinal number.</returns>
        public static string Ordinal(this int number)
        {
            int firstDigit = number % 10;
            int secondDigit = number % 100 / 10;

            if (secondDigit.Absolute() == 1)
            {
                return string.Format("{0}th", number);
            }
            else
            {
                switch (firstDigit.Absolute())
                {
                    case 1:
                        return string.Format("{0}st", number);
                    case 2:
                        return string.Format("{0}nd", number);
                    case 3:
                        return string.Format("{0}rd", number);
                    default:
                        return string.Format("{0}th", number);
                }
            }
        }
    }
}
