using System.Collections.Generic;
using System.Collections.ObjectModel;
using LifePath.Common.Entities;

namespace LifePath.DataLayer
{
    public static partial class Data
    {
        public static ReadOnlyCollection<Gender> Genders = new ReadOnlyCollection<Gender>(new List<Gender>()
        {
            new Gender(0, "Male"),
            new Gender(1, "Female"),
        });
    }
}
