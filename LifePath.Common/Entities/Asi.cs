using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifePath.Common.Entities
{
    /// <summary>
    /// (Ability Score Increase) A change to an <see cref="Ability"/>.
    /// </summary>
    public class Asi
    {
        /// <summary>
        /// The <see cref="Ability"/> to be changed.
        /// </summary>
        public Ability Ability { get; set; }

        /// <summary>
        /// The value to change the <see cref="Ability"/> by.
        /// </summary>
        public int Increase { get; set; }

        /// <summary>
        /// Creates a new instance of the <see cref="Asi"/> class.
        /// </summary>
        /// <param name="ability">The (non-null) <see cref="Ability"/> to be changed.</param>
        /// <param name="increase">The (non-null) value to change the <see cref="Ability"/> by.</param>
        public Asi(Ability ability, int increase)
        {
            ArgumentCheck.ThrowOnNull(ability);
            ArgumentCheck.ThrowOnNull(increase);
            Ability = ability;
            Increase = increase;
        }

        /// <summary>
        /// Creates a new instance of the <see cref="Asi"/> class.
        /// </summary>
        /// <param name="ability">The (non-null) id of the <see cref="Ability"/> to be changed.</param>
        /// <param name="increase">The (non-null) value to change the <see cref="Ability"/> by.</param>
        public Asi(int ability, int increase)
        {
            ArgumentCheck.ThrowOnNull(ability);
            ArgumentCheck.ThrowOnNull(increase);
            Ability = (Ability)ability;
            Increase = increase;
        }
    }
}
