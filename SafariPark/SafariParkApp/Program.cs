using System.Collections.Generic;


namespace SafariParkApp
{
    public class Program 
    {
        static void Main(string[] args)
        {
            var helen = new Person { FirstName = "helen", LastName = "troy", Age = 22 };
            var will = new Hunter("william", "shakespeare", new Camera("cannon")) { Age = 457 };
            Console.WriteLine("list of people");
            List<Person> thepeople = new List<Person> { helen, will };

            foreach (var person in thepeople)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine();


            Console.WriteLine("Linked list of people");
            LinkedList<Person> thePeopleLinked = new LinkedList<Person>();
            var firstNode = thePeopleLinked.AddFirst(helen);
            thePeopleLinked.AddLast(will);
            thePeopleLinked.AddLast(new Person { FirstName = "Linda", LastName = "Smith", Age = 45 }); ;
            thePeopleLinked.AddAfter(firstNode, new Person { FirstName = "John", LastName = "Green", Age = 2 }); ;

            foreach (var person in thePeopleLinked)
            {
                Console.WriteLine(person);
            }





            List<int> nums = new List<int> { 5, 4, 3, 9, 0 };
            nums.Add(8);
            nums.Sort();
            nums.RemoveRange(1, 2);
            nums.Insert(2, 1);
            nums.Reverse();
            nums.Remove(9);
            foreach (int i in nums)
            {
                Console.Write(i);
            }
            // Console.WriteLine(string.Join("", nums));
            //nums.ForEach(Console.WriteLine);

            var myQueue = new Queue<Person>();
            myQueue.Enqueue(helen);
            myQueue.Enqueue(will);
            myQueue.Enqueue(new Person("Cathy"));
            Console.WriteLine("\nQueue");
            foreach (var q in myQueue)
            {
                Console.WriteLine(q);
            }
            var first = myQueue.Peek();
            var serve = myQueue.Dequeue();
            var second = myQueue.Peek();
            var served = myQueue.Dequeue();


            int[] original = new int[] { 1, 2, 3, 4, 5 };
            int[] reversed = new int[original.Length];
            var stack = new Stack<int>();
            foreach(var n in original)
            {
                stack.Push(n);
            }
            Console.WriteLine("\nStack"); 
            foreach(var s in stack)
            {
                Console.WriteLine(s);
            }

            for (int i = 0; i < original.Length; i++)
            {
                reversed[i] = stack.Pop();
                Console.WriteLine(stack);
            }

            var peopleSet = new HashSet<Person>
            {
                helen, new Person("Jasmine"), new Person ("Andrei")
            };
            Console.WriteLine("HashSet");
            foreach (var entry in peopleSet)
            {
                Console.WriteLine(entry);
            }

            var successMartin = peopleSet.Add(new Person { FirstName = "Martin", LastName = "Beard" });
            var successHelen = peopleSet.Add(new Person { FirstName = "Helen", LastName = "Troy", Age = 22 });

            var morePeople = new HashSet<Person> { new Person("Cathy"), new Person("Jasmine") };
            peopleSet.IntersectWith(morePeople);

            var personDict = new Dictionary<string, Person>
            {
                {"helen", helen},
                {"sherlock", new Person("Sherlock", "Jones"){Age = 40 } }
            };
            var p = personDict["sherlock"];
            personDict.Add("will", will);

            string input = "The cat in the hat comes back";
            input = input.Trim().ToLower();
            var countDict = new Dictionary<char, int>();

            foreach (var c in input) 
            {
                if (countDict.ContainsKey(c))
                {
                    countDict[c]++;
                }
                else
                {
                    countDict.Add(c, 1);
                }
            }
            Console.WriteLine("Dictionary problem");
            foreach(var entry in countDict)
            {
                Console.WriteLine(entry);
            }
            Console.WriteLine("\nKeys");
            foreach(var key in countDict.Keys)
            {
                Console.WriteLine(key + " ");
            }
            Console.WriteLine("\nValues");
            foreach(var value in countDict.Values)
            {
                Console.WriteLine(value + " ");
            }
        }







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


        //static void Main(string[] args)
        //{
        //    var robOne = new Person("Robert", "Sponge") { Age = 20 };
        //    var robTwo = robOne;
        //    var areSame = robOne.Equals(robTwo); // True

        //    var robThree = new Person("Robert", "Sponge") { Age = 20 };
        //    var areSameOneThree = robOne.Equals(robThree); // false

        //    List<Person> personList =
        //        new List<Person>
        //        {
        //            new Person("Bobert", "Sponge"),

        //            new Person("Sandy", "Cheeks") { Age = 25},

        //            new Person("Robert", "Sponge"),

        //            new Person("Squilliam", "Squad") { Age = 32}
        //        };
        //    foreach (var person in personList)
        //    {
        //        Console.WriteLine(person);
        //    }

        //    var hasRob = personList.Contains(robOne);
        //    var equals = robOne == robThree;
        //    var notEquals = robOne != robThree;

        //    personList.Sort();


        //     var robfour = new Person("A", "B");
        //     var robfive = new Person("C", "D");
        //     var isSame = robfour.CompareTo(robfive);
        //    Console.WriteLine(isSame);




        //    //------------------------------Shoot------------------------------------------------------
        //    //Camera pentax = new Camera("Pentax");
        //    //WaterPistol pistol = new WaterPistol("Supersoaker");
        //    //LaserGun laserGun = new LaserGun("Acme");
        //    //Hunter nish = new Hunter("Nish", "Mandal", pentax);
        //    //Console.WriteLine(nish.Shoot());
        //    //nish.Shooter = pistol;
        //    //Console.WriteLine(nish.Shoot());
        //    //nish.Shooter = laserGun;
        //    //Console.WriteLine(nish.Shoot());
        //    //nish.Shooter = pistol;
        //    //Console.WriteLine(nish.Shoot());

        //    //------------------------------------------------------------------------------------

        //    //Hunter h = new Hunter("Marion", "Jones", "Leica") { Age = 32};
        //    ////Console.WriteLine(h.Age);
        //    ////Console.WriteLine(h.Shoot());
        //    //var h2 = new Hunter("Marion", "Jones", "Leica") { Age = 32 };
        //    //Console.WriteLine($"h Equals h2? {h.Equals(h2)}");
        //    //Console.WriteLine($"h HashCode: {h.GetHashCode()}");
        //    //Console.WriteLine($"h Type: {h.GetType()}");
        //    //Console.WriteLine($"h ToString: {h.ToString()}");
        //    //Console.WriteLine($"h: {h}");

        //    //Rect
        //    //var rect = new Rectangle(3, 4);
        //    //Console.WriteLine(rect);

        //    //------------------------------Airplane------------------------------------------------------
        //    //Airplane
        //    //Airplane a = new Airplane(200, 100, "JetsRUs")
        //    //{ NumPassengers = 150 };
        //    //a.Ascend(500);
        //    //Console.WriteLine(a.Move(3));
        //    //Console.WriteLine(a);
        //    //a.Descend(200);
        //    //Console.WriteLine(a.Move());
        //    //a.Move();
        //    //Console.WriteLine(a);

        //    //------------------------------Polymorphism------------------------------------------------------

        //    //            List<Object> gameObjects = new List<Object>()
        //    //            {
        //    //                new Person ("Cathy", "French"),
        //    //                new Hunter ("Stephano", "Naresso", "Iphone13")
        //    //            };
        //    //            foreach (var gameObj in gameObjects)
        //    //            {
        //    //                Console.WriteLine(gameObj);
        //    //            }

        //    //            Person yolondo = new Person("Yolondo", "Young");
        //    //            SpartaWrite(yolondo);
        //    ////--------------------------------------------------------------------------------------------

        //    //            List<iMoveable> PeopleWalk = new List<iMoveable>()
        //    //            {
        //    //                new Person("A", "B"),
        //    //                new Vehicle(100, 10)
        //    //            };

        //    //            foreach (var moveable in PeopleWalk)
        //    //            {
        //    //                Console.WriteLine(moveable.Move(5));
        //    //            }

        //    //List<IShootable> Guns = new List<IShootable>()
        //    //{
        //    //    new LaserGun("H&K"),
        //    //    new WaterPistol("Glock"),
        //    //    new Hunter("A", "B", new WaterPistol("Volkite")),
        //    //    new Hunter("D", "E", new LaserGun("LasGun")),
        //    //    new Camera("Cannon")
        //    //};

        //    //foreach (var shoota in Guns)
        //    //{
        //    //    Console.WriteLine(shoota.Shoot());
        //    //}

        //}


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