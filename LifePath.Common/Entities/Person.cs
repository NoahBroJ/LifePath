using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifePath.Common.Entities
{
    /// <summary>
    /// A person the <see cref="Character"/> knowns.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// The nature of the <see cref="Person"/>'s relationship with the <see cref="Character"/>.
        /// </summary>
        public string Relation { get; set; }

        /// <summary>
        /// The name of the <see cref="Person"/>.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The <see cref="Race"/> of the <see cref="Person"/>.
        /// </summary>
        public Race Race { get; set; }

        /// <summary>
        /// The occupation of the <see cref="Person"/>.
        /// </summary>
        public string Occupation { get; set; }

        /// <summary>
        /// The current status of the <see cref="Person"/>.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// The <see cref="Person"/>'s attittude toward the <see cref="Character"/>.
        /// </summary>
        public string Attittude { get; set; }
    }
}
