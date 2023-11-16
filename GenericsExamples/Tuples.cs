namespace GenericsExamples
{
    public class Tuple<T> /* public class TupleOfT */
    {
        public T Item1 { get; set; };
    }

    public class Tuple<T1, T2> : Tuple<T1> /* public class TupleOfT1AndT2: TupleOfT */
    {
        public T2 Item2 { get; set; }
    }

    public class Tuple<T1, T2, T3> : Tuple<T1, T2>
    {
        public T3 Item3 { get; set; }
    }

    public class Person : IComparable<Person>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int CompareTo(Person other)
        {
            if (other is null)
            {
                return 1;
            }

            if (this.DateOfBirth < other.DateOfBirth)
            {
                // current instance is older, hence greater
                return 1;
            }

            if (this.DateOfBirth > other.DateOfBirth)
            {
                // current instance is younger, hence lesser
                return -1;
            }

            // both current instance and other have the same DateOfBirth
            return 0;
        }
    }

    public class Student : Person
    {
        public string University { get; set; }
    }
}
