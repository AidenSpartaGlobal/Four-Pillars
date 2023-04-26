namespace SafariParkApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Person joe = new("Joe", "McCann", 40);
            //Console.WriteLine(joe.FullName);

            //Person nish = new Person("Nish", "Mandal", 52);
            //Console.WriteLine(nish.FullName);

            //Person martin = new Person("Martin");
            //Person michael = new Person("Michael", "Flynn");
            //michael.Age = 32;
            //Console.WriteLine(michael.Age);
            //michael.Age = 100;
            //Console.WriteLine($"{michael.FirstName} is Michael's first name");
            var alex = new Person("Alex", "Blunt") { Age = 31};
            var list = new ShoppingList() { Bread = 2, Potato = 6, Milk = 2 };
            var manvir = new Person() { FirstName = "Manvir", LastName = "Nandra", Age = 25 };
            Point3D p = new Point3D(3, 6, 2);
            var p2 = new Point3D();
            Point3D p3;
            Point3D p4 = new Point3D(1, 7);
            Person akito = new Person("Akito", "Oyama") { Age = 20};
            Point3D pt3D = new Point3D(5, 8, 2);
            DemoMethod(pt3D, akito);
        }

        static void DemoMethod(Point3D pt, Person p)
        {
            pt.y = 1000;
            p.Age = 92;
        }
    }
}