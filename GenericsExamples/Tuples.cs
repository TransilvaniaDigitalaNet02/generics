namespace GenericsExamples
{
    public class Tuple<T> /* public class TupleOfT */
    {
        public T Item1 { get; set; }
    }

    public class Tuple<T1, T2> : Tuple<T1> /* public class TupleOfT1AndT2: TupleOfT */
    {
        public T2 Item2 { get; set; }
    }

    public class Tuple<T1, T2, T3> : Tuple<T1, T2>
    {
        public T3 Item3 { get; set; }
    }

    public class Person
    {
        public int Id { get; set; }
    }
}
