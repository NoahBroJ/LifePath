using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifePath.Common.Entities
{
    /// <summary>
    /// The <see cref="Character"/>'s family relations and overall upbringing.
    /// </summary>
    public class Nurture
    {
        /// <summary>
        /// The collection of <see cref="Person"/>s considered the <see cref="Character"/>'s family.
        /// </summary>
        public IList<Person> Family { get; }

        /// <summary>
        /// The conditions under which the <see cref="Character"/> was brought up.
        /// </summary>
        public LifeStyle Upbringing { get; }

        /// <summary>
        /// The childhood home of the <see cref="Character"/>.
        /// </summary>
        public string Home { get; }
    }
}
