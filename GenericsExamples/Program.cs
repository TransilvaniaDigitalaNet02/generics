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

            /*
            int x = 10;
            int y = 20;
            VariableSwapper.Swap(ref x, ref y);
            Console.WriteLine(x);
            Console.WriteLine(y);

            var o = ObjectFactory.Create<Person>();

            
            string text1 = "text1";
            string text2 = "text2";
            VariableSwapper.Swap(ref text1, ref text2);
            Console.WriteLine(text1);
            Console.WriteLine(text2);
            */

            Student s1 = new Student
            {
                Id = 1,
                Name = "Student 1",
                DateOfBirth = new DateTime(1985, 11, 14),
                University = "Universitatea Bucuresti"
            };

            Student s2 = new Student
            {
                Id = 2,
                Name = "Student 2",
                DateOfBirth = new DateTime(1986, 11, 14),
                University = "Universitatea Bucuresti"
            };

            Student s3 = new Student
            {
                Id = 3,
                Name = "Student 3",
                DateOfBirth = new DateTime(1986, 11, 14),
                University = "Universitatea Bucuresti"
            };

            Person p1 = s1;

            // ListOfStudents
            IEnumerable<Student> students = new List<Student>(new Student[]
            {
                s1, s2, s3
            });

            // ListOfPerson
            IEnumerable<Person> persons = students;


            IPersonPrinter<Person> personPrinter = new PersonPrinter<Person>();
            IPersonPrinter<Student> studentPrinter = personPrinter; // IPersonPrinter<Person> personPrinter
            studentPrinter.Print(s1);


            // ChildClass : BaseClass
            // Generic<T> (e.g.: List<T>, Tuple<T>, ... etc)

            // invariance:            Generic<BaseClass> != Generic<ChildClass>
            // co-variance (out):     Generic<BaseClass>  = Generic<ChildClass> (implicit conversion from ChildClass => BaseClass possible)
            //                        e.g.: IEnumerable<Person> = IEnumerable<Student>
            // contra-variance (in):  Generic<ChildClass>  = Generic<BaseClass> (conversion against OOP from ChildClass => BaseClass possible)
            //                        e.g.: IPersonPrinter<Student> = IPersonPrinter<Person>
        }
    }
}