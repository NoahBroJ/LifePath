using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifePath.Common.Entities
{
    /// <summary>
    /// The <see cref="Character"/>'s life up until the start of their adventuring career.
    /// </summary>
    public class Life
    {
        /// <summary>
        /// The current path of <see cref="Life"/>.
        /// </summary>
        public LifePath LifePath { get; set; }

        /// <summary>
        /// The events that have taken place in <see cref="Life"/>.
        /// </summary>
        public IList<Tuple<int, Event>> LifeEvents { get; set; }
    }
}
