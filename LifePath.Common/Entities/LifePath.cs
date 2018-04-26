using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifePath.Common.Entities
{
    /// <summary>
    /// A way of life, affecting what <see cref="Event"/>s occur during <see cref="Life"/>.
    /// </summary>
    public class LifePath
    {
        /// <summary>
        /// The id of the <see cref="LifePath"/>.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// The name of the <see cref="LifePath"/>.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The description of the <see cref="LifePath"/>.
        /// </summary>
        public string Description { get; }
    }
}
