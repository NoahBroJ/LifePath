using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifePath.Common.Entities
{
    /// <summary>
    /// The <see cref="Character"/>'s gender.
    /// </summary>
    public class Gender
    {
        public Gender(int id, string name)
        {
            Id = id;
            Name = name;
        }

        /// <summary>
        /// The id of the <see cref="Gender"/>.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// The name of the <see cref="Gender"/>.
        /// </summary>
        public string Name { get; }
    }
}
