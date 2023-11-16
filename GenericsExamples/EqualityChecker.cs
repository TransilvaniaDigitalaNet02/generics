namespace GenericsExamples
{
    internal static class EqualityChecker
    {
        public static bool AreEqual<T>(T obj1, T obj2)
            where T : IComparable<T>
        {
            if (obj1 is not null && obj2 is not null)
            {
                // both are not null

                // do the comparison
                return obj1.CompareTo(obj2) == 0;
            }
            else
            {
                if (obj1 is null && obj2 is null)
                {
                    // both are null
                    return true;
                }
                else
                {
                    // one of them is null
                    return false;
                }
            }
        }
    }
}
