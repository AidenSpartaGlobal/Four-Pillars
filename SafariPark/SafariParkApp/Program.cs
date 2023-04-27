namespace SafariParkApp
{
    public class Program 
    {
        //static void Main(string[] args)
        //{
        //    //Person joe = new("Joe", "McCann", 40);
        //    //Console.WriteLine(joe.FullName);

        //    //Person nish = new Person("Nish", "Mandal", 52);
        //    //Console.WriteLine(nish.FullName);

        //    //Person martin = new Person("Martin");
        //    //Person michael = new Person("Michael", "Flynn");
        //    //michael.Age = 32;
        //    //Console.WriteLine(michael.Age);
        //    //michael.Age = 100;
        //    //Console.WriteLine($"{michael.FirstName} is Michael's first name");
        //    //var alex = new Person("Alex", "Blunt") { Age = 31};
        //    //var list = new ShoppingList() { Bread = 2, Potato = 6, Milk = 2 };
        //    //var manvir = new Person() { FirstName = "Manvir", LastName = "Nandra", Age = 25 };
        //    //Point3D p = new Point3D(3, 6, 2);
        //    //var p2 = new Point3D();
        //    //Point3D p3;
        //    //Point3D p4 = new Point3D(1, 7);
        //    //Person akito = new Person("Akito", "Oyama") { Age = 20};
        //    //Point3D pt3D = new Point3D(5, 8, 2);
        //    //DemoMethod(pt3D, akito);
        //}

        //static void DemoMethod(Point3D pt, Person p)
        //{
        //    pt.y = 1000;
        //    p.Age = 92;
        //}


        static void Main(string[] args)
        {
            Camera pentax = new Camera("Pentax");
            WaterPistol pistol = new WaterPistol("Supersoaker");
            LaserGun laserGun = new LaserGun("Acme");
            Hunter nish = new Hunter("Nish", "Mandal", pentax);
            Console.WriteLine(nish.Shoot());
            nish.Shooter = pistol;
            Console.WriteLine(nish.Shoot());
            nish.Shooter = laserGun;
            Console.WriteLine(nish.Shoot());
            nish.Shooter = pistol;
            Console.WriteLine(nish.Shoot());



            //Hunter h = new Hunter("Marion", "Jones", "Leica") { Age = 32};
            ////Console.WriteLine(h.Age);
            ////Console.WriteLine(h.Shoot());
            //var h2 = new Hunter("Marion", "Jones", "Leica") { Age = 32 };
            //Console.WriteLine($"h Equals h2? {h.Equals(h2)}");
            //Console.WriteLine($"h HashCode: {h.GetHashCode()}");
            //Console.WriteLine($"h Type: {h.GetType()}");
            //Console.WriteLine($"h ToString: {h.ToString()}");
            //Console.WriteLine($"h: {h}");

            //Rect
            //var rect = new Rectangle(3, 4);
            //Console.WriteLine(rect);

            //------------------------------Airplane------------------------------------------------------
            //Airplane
            //Airplane a = new Airplane(200, 100, "JetsRUs")
            //{ NumPassengers = 150 };
            //a.Ascend(500);
            //Console.WriteLine(a.Move(3));
            //Console.WriteLine(a);
            //a.Descend(200);
            //Console.WriteLine(a.Move());
            //a.Move();
            //Console.WriteLine(a);

            //------------------------------Polymorphism------------------------------------------------------

            //            List<Object> gameObjects = new List<Object>()
            //            {
            //                new Person ("Cathy", "French"),
            //                new Hunter ("Stephano", "Naresso", "Iphone13")
            //            };
            //            foreach (var gameObj in gameObjects)
            //            {
            //                Console.WriteLine(gameObj);
            //            }

            //            Person yolondo = new Person("Yolondo", "Young");
            //            SpartaWrite(yolondo);
            ////--------------------------------------------------------------------------------------------

            //            List<iMoveable> PeopleWalk = new List<iMoveable>()
            //            {
            //                new Person("A", "B"),
            //                new Vehicle(100, 10)
            //            };

            //            foreach (var moveable in PeopleWalk)
            //            {
            //                Console.WriteLine(moveable.Move(5));
            //            }

            //List<IShootable> Guns = new List<IShootable>()
            //{
            //    new LaserGun("H&K"),
            //    new WaterPistol("Glock"),
            //    new Hunter("A", "B", new WaterPistol("Volkite")),
            //    new Hunter("D", "E", new LaserGun("LasGun")),
            //    new Camera("Cannon")
            //};

            //foreach (var shoota in Guns)
            //{
            //    Console.WriteLine(shoota.Shoot());
            //}

        }


        //public static void SpartaWrite(Object obj)
        //{
        //    Console.WriteLine(obj.ToString());
        //    if (obj is Hunter)
        //    {
        //        var hunterObj = (Hunter)obj;
        //        Console.WriteLine(hunterObj.Shoot);
        //    }
        //}
//--------------------------------------------------------------------------------------------

    }
}