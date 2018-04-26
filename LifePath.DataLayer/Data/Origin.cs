using System.Collections.Generic;
using System.Collections.ObjectModel;
using LifePath.Common.Entities;

namespace LifePath.DataLayer
{
    public static partial class Data
    {
        public static ReadOnlyCollection<Event> Origins = new ReadOnlyCollection<Event>(new List<Event>()
        {
            new Gender(0, "Male"),
            new Gender(1, "Female"),
        });
    }
}
