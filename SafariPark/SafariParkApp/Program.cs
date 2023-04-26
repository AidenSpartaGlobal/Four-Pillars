namespace SafariParkApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person joe = new("Joe", "McCann", 40);
            Console.WriteLine(joe.FullName);

            Person nish = new Person("Nish", "Mandal", 52);
            Console.WriteLine(nish.FullName);

            Person martin = new Person("Martin");
            Person michael = new Person("Michael", "Flynn");
            michael.Age = 32;
            Console.WriteLine(michael.Age);
            michael.Age = 100;
            Console.WriteLine($"{michael.FirstName} is Michael's first name");
        }
    }
}