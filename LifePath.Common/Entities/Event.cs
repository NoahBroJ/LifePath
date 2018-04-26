using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifePath.Common.Entities
{
    /// <summary>
    /// An event occuring in the <see cref="Character"/>'s <see cref="Life"/>.
    /// </summary>
    public class Event
    {
        /// <summary>
        /// The id of the <see cref="Event"/>.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// The description of the <see cref="Event"/>.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// The <see cref="Response"/> chosen for the <see cref="Event"/>.
        /// </summary>
        public Response Response { get; }
    }
}
