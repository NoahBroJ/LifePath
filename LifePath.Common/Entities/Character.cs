using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifePath.Common.Entities
{
    /// <summary>
    /// The character being built using the Life Path method.
    /// </summary>
    public class Character
    {
        /// <summary>
        /// The <see cref="Character"/>'s <see cref="Race"/> and <see cref="Gender"/>.
        /// </summary>
        public Nature Nature { get; set; }

        /// <summary>
        /// The circumstances of the <see cref="Character"/>'s origin.
        /// </summary>
        public Event Origin { get; set; }

        /// <summary>
        /// The <see cref="Character"/>'s upbringing and childhood.
        /// </summary>
        public Nurture Nurture { get; set; }

        /// <summary>
        /// The <see cref="Character"/>'s life up until the start of their adventuring career.
        /// </summary>
        public Life Life { get; set; }

        /// <summary>
        /// The effect the <see cref="Character"/>'s age has on their life.
        /// </summary>
        public Action AgeBonus { get; set; }

        /// <summary>
        /// The <see cref="Character"/>'s ability scores.
        /// </summary>
        public Asa AbilityScoreArray { get; set; }
    }
}
