using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifePath.Common.Entities
{
    /// <summary>
    /// The <see cref="Character"/>'s <see cref="Race"/> and <see cref="Gender"/>.
    /// </summary>
    public class Nature
    {
        /// <summary>
        /// The <see cref="Character"/>'s race.
        /// </summary>
        public Race Race { get; set; }

        /// <summary>
        /// The <see cref="Character"/>'s gender.
        /// </summary>
        public Gender Gender { get; set; }
    }
}
