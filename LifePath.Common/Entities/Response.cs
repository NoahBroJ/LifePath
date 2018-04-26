using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifePath.Common.Entities
{
    /// <summary>
    /// A response to an event in the <see cref="Character"/>'s life.
    /// </summary>
    public class Response
    {
        /// <summary>
        /// The id of the <see cref="Response"/>.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// The description of the <see cref="Response"/>.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// The result of choosing the <see cref="Response"/> on the <see cref="Character"/>.
        /// </summary>
        public Action Result { get; }
    }
}
