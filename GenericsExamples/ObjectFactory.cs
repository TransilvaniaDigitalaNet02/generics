namespace GenericsExamples
{
    internal static class ObjectFactory
    {
        public static T Create<T>()
            where T: new()
        {
            return new T();
        }
    }
}
