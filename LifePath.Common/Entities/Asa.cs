using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifePath.Common.Entities
{
    /// <summary>
    /// An array of ability scores.
    /// </summary>
    public class Asa
    {
        /// <summary>
        /// The <see cref="Ability.Strength"/> score.
        /// </summary>
        public int Strength { get; set; }

        /// <summary>
        /// The <see cref="Ability.Dexterity"/> score.
        /// </summary>
        public int Dexterity { get; set; }

        /// <summary>
        /// The <see cref="Ability.Constitution"/> score.
        /// </summary>
        public int Constitution { get; set; }

        /// <summary>
        /// The <see cref="Ability.Intelligence"/> score.
        /// </summary>
        public int Intelligence { get; set; }

        /// <summary>
        /// The <see cref="Ability.Wisdom"/> score.
        /// </summary>
        public int Wisdom { get; set; }

        /// <summary>
        /// The <see cref="Ability.Charisma"/> score.
        /// </summary>
        public int Charisma { get; set; }

        /// <summary>
        /// Creates a new instance of the <see cref="Asa"/> class with 0 in all ability scores.
        /// </summary>
        public Asa()
        {
            Strength = 0;
            Dexterity = 0;
            Constitution = 0;
            Intelligence = 0;
            Wisdom = 0;
            Charisma = 0;
        }

        /// <summary>
        /// Creates a new instance of the <see cref="Asa"/> class.
        /// </summary>
        /// <param name="strength">The <see cref="Ability.Strength"/> score.</param>
        /// <param name="dexterity">The <see cref="Ability.Dexterity"/> score.</param>
        /// <param name="constitution">The <see cref="Ability.Constitution"/> score.</param>
        /// <param name="intelligence">The <see cref="Ability.Intelligence"/> score.</param>
        /// <param name="wisdom">The <see cref="Ability.Wisdom"/> score.</param>
        /// <param name="charisma">The <see cref="Ability.Charisma"/> score.</param>
        public Asa(int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
        {
            Strength = strength;
            Dexterity = dexterity;
            Constitution = constitution;
            Intelligence = intelligence;
            Wisdom = wisdom;
            Charisma = charisma;
        }

        /// <summary>
        /// Adds an <see cref="Asi"/>'s increase to the relevant <see cref="Ability"/> in an <see cref="Asa"/>.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="increase"></param>
        /// <returns></returns>
        public static Asa operator+ (Asa array, Asi increase)
        {
            switch (increase.Ability)
            {
                case Ability.Strength:
                    array.Strength += increase.Increase;
                    return array;
                case Ability.Dexterity:
                    array.Dexterity += increase.Increase;
                    return array;
                case Ability.Constitution:
                    array.Constitution += increase.Increase;
                    return array;
                case Ability.Intelligence:
                    array.Intelligence += increase.Increase;
                    return array;
                case Ability.Wisdom:
                    array.Wisdom += increase.Increase;
                    return array;
                case Ability.Charisma:
                    array.Charisma += increase.Increase;
                    return array;
                default:
                    throw new ArgumentException("Invalid Ability Score Increase", nameof(increase));
            }
        }
    }
}
