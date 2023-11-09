using System.Collections.ObjectModel;

namespace GenericsExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            List<int> listOfIntegers = new List<int>();
            listOfIntegers.AddRange(new int[] { 1, 2, 3 });
            int i = listOfIntegers[0];

            Tuple<string> tuple1 = new Tuple<string>();
            tuple1.Item1 = "test";

            Tuple<int> tuple1b = new Tuple<int>();
            tuple1b.Item1 = 10;


            Tuple<int, bool> tuple2 = new Tuple<int, bool>();
            tuple2.Item1 = 10;
            tuple2.Item2 = true;


            Tuple<string, int, DateTime> tuple3 = new Tuple<string, int, DateTime>();
            tuple3.Item1 = "test";
            tuple3.Item2 = 10;
            tuple3.Item3 = DateTime.Now;
            */

            int x = 10;
            int y = 20;
            VariableSwapper.Swap<int>(ref x, ref y);
            Console.WriteLine(x);
            Console.WriteLine(y);

            string text1 = "text1";
            string text2 = "text2";
            VariableSwapper.Swap<string>(ref text1, ref text2);
            Console.WriteLine(text1);
            Console.WriteLine(text2);
        }
    }
}