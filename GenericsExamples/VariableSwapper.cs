namespace GenericsExamples
{
    public static class VariableSwapper
    {
        public static void Swap<T>(ref T var1, ref T var2)
            where T : new()
        {
            T temp = var1;
            var1 = var2;
            var2 = temp;
        }
    }
}
