namespace GenericsExamples
{
    internal class PersonPrinter<T> : IPersonPrinter<T>
        where T : Person
    {
        public void Print(T person)
        {
            if (person is not null)
            {
                Console.WriteLine($"{person.Id} - {person.Name}, d.o.b.: {person.DateOfBirth}");
            }
        }
    }

    internal interface IPersonPrinter<in T>
    {
        void Print(T person);
    }
}
