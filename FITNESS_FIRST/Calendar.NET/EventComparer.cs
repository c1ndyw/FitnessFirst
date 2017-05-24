using System.Collections.Generic;

namespace Calendar.NET
{
    internal class EventComparer : IComparer<IEvent>
    {
        public int Compare(IEvent x, IEvent y)
        {
            int rankComp = x.Rank.CompareTo(y.Rank);

            if (rankComp == 0)
            {
                int comp1 = x.StartDate.Day.CompareTo(y.StartDate.Day);

                if (comp1 == 0)
                {
                    int comp2 = x.StartDate.Month.CompareTo(y.StartDate.Month);

                    if (comp2 == 0)
                    {
                        int comp3 = x.StartDate.Year.CompareTo(y.StartDate.Year);

                        if (comp3 == 0)
                        {
                            int comp4 = x.StartDate.Hour.CompareTo(y.StartDate.Hour);

                            if (comp4 == 0)
                            {
                                int comp5 = x.StartDate.Minute.CompareTo(y.StartDate.Minute);

                                if (comp5 == 0)
                                {
                                    return x.Rank.CompareTo(y.Rank);
                                }

                                return comp5;
                            }

                            return comp4;
                        }
                        return comp3;
                    }

                    return comp2;
                }

                return comp1;
            }
            return rankComp;
        } 
    }
}
