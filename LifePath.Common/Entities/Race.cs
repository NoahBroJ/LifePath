using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifePath.Common.Entities
{
    /// <summary>
    /// The <see cref="Character"/>'s race.
    /// </summary>
    public class Race
    {
        public Race(int id, string name, Main? mainRace, IReadOnlyList<Asi> asis, Maturity aging, string source)
        {
            Id = id;
            Name = name;
            MainRace = mainRace;
            Asis = asis;
            Aging = aging;
            Source = source;
        }

        /// <summary>
        /// The id of the <see cref="Race"/>.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// The name of the <see cref="Race"/>.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// The (possibly null) <see cref="Main"/> race that the <see cref="Race"/> is a subrace of.
        /// </summary>
        public Main? MainRace { get; }

        /// <summary>
        /// The <see cref="Asi"/>s associated with the <see cref="Race"/>.
        /// </summary>
        public IReadOnlyList<Asi> Asis { get; }

        /// <summary>
        /// The <see cref="Race"/>'s process of maturing.
        /// </summary>
        public Maturity Aging { get; }

        /// <summary>
        /// The official source of the <see cref="Race"/>.
        /// </summary>
        public string Source { get; }

        /// <summary>
        /// A main race to which a subrace may belong.
        /// </summary>
        public enum Main
        {
            Aasimar,
            Dwarf,
            Elf,
            Genasi,
            Gnome,
            Halfling,
            Human,
            Tiefling,
        }

        /// <summary>
        /// An expression of a <see cref="Race"/>'s process of maturing.
        /// </summary>
        public class Maturity
        {
            /// <summary>
            /// A collection of seven ages at which a member of the given <see cref="Race"/> is considered to transition into different stages of maturity:
            /// Child, Young, Young Adult, Adult, Middle-Aged, Aged, Old, Dead.
            /// </summary>
            public IReadOnlyList<int> AgeRanges { get; }

            /// <summary>
            /// Instantiates a new instance of the <see cref="Maturity"/> class.
            /// </summary>
            /// <param name="childToYoung">The (non-null, non-negative) age at which a member of the given <see cref="Race"/> is considered to transition from child to young.</param>
            /// <param name="youngToYoungAdult">The (non-null, non-negative) age at which a member of the given <see cref="Race"/> is considered to transition from young to young adult.</param>
            /// <param name="youngAdultToAdult">The (non-null, non-negative) age at which a member of the given <see cref="Race"/> is considered to transition from young adult to adult.</param>
            /// <param name="adultToMiddleAged">The (non-null, non-negative) age at which a member of the given <see cref="Race"/> is considered to transition from adult to middle-aged.</param>
            /// <param name="middleAgedToAged">The (non-null, non-negative) age at which a member of the given <see cref="Race"/> is considered to transition from middle-aged to aged.</param>
            /// <param name="agedToOld">The (non-null, non-negative) age at which a member of the given <see cref="Race"/> is considered to transition from aged to old.</param>
            /// <param name="oldToDead">The (non-null, non-negative) age at which a member of the given <see cref="Race"/> typically dies of old age.</param>
            public Maturity(int childToYoung, int youngToYoungAdult, int youngAdultToAdult, int adultToMiddleAged, int middleAgedToAged, int agedToOld, int oldToDead)
            {
                List<int> args = new List<int>() { childToYoung, youngToYoungAdult, youngAdultToAdult, adultToMiddleAged, middleAgedToAged, agedToOld, oldToDead };

                for (int i = 0; i < args.Count; i++)
                {
                    ArgumentCheck.ThrowOnNull(args[i]);
                    if (i == 0)
                    {
                        if (args[i] < 0)
                        {
                            throw new ArgumentOutOfRangeException(nameof(args), "First argument cannot be negative");
                        }
                    }
                    else
                    {
                        if (args[i] < args[i - 1])
                        {
                            throw new ArgumentOutOfRangeException(nameof(args), string.Format("{0} argument cannot be less than previous argument", (i + 1).Ordinal()));
                        }
                    }
                }

                AgeRanges = new List<int>(args);
            }

            /// <summary>
            /// Finds the next maturity stage transition for a given age from the <see cref="AgeRanges"/> property.
            /// </summary>
            /// <param name="age">The (non-null, non-negative) age to find the stage for.</param>
            /// <returns>The index of the next maturity stage transition in the <see cref="AgeRanges"/> property.</returns>
            public int MaturityStage(int age)
            {
                ArgumentCheck.ThrowOnNull(age);
                if (age < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(age), "Argument cannot be negative");
                }

                int? stageIndex = null;

                foreach (int stage in AgeRanges)
                {
                    if (age < stage)
                    {
                        stageIndex = AgeRanges.ToList().IndexOf(stage);
                        break;
                    }
                }

                if (!stageIndex.HasValue)
                {
                    stageIndex = 7;
                }

                return stageIndex.Value;
            }

            /// <summary>
            /// Returns the name of the current maturity stage for a given age.
            /// </summary>
            /// <param name="age">The (non-null, non-negative) age to find the maturity stage for.</param>
            /// <returns>The name of a maturity stage.</returns>
            public string MaturityStageString(int age)
            {
                switch (MaturityStage(age))
                {
                    case 0:
                        return "child";
                    case 1:
                        return "young";
                    case 2:
                        return "young adult";
                    case 3:
                        return "adult";
                    case 4:
                        return "middle-aged";
                    case 5:
                        return "aged";
                    case 6:
                        return "old";
                    case 7:
                        return "dead";
                    default:
                        throw new ArgumentException(nameof(MaturityStage));
                }
            }
        }
    }
}
