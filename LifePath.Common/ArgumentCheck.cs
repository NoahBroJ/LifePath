using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifePath.Common
{
    /// <summary>
    /// Static class for checking arguments.
    /// </summary>
    static class ArgumentCheck
    {
        /// <summary>
        /// Throw <see cref="ArgumentNullException"/> if argument is <see cref="null"/>
        /// </summary>
        /// <param name="argument">The argument to be checked.</param>
        public static void ThrowOnNull(object argument)
        {
            if (argument == null)
            {
                throw new ArgumentNullException(nameof(argument));
            }
        }
    }
}
