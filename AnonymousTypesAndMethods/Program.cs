using Static;

namespace AnonymousTypesAndMethods
{
    public class Singleton
    {
        public static Singleton Instance { get; set; } = new Singleton();

        private Singleton()
        {
        }

        public void DoSomething()
        {
            Console.WriteLine("Do something");
        }
    }

    class MyClass
    {
        public static string Name { get; set; } = "MyClass";
        public string FirstName { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();
            logger.Log("asdasdasd");

            Logger2 logger2 = new Logger2();
            logger2;

            MyClass x = new MyClass() { FirstName = "John" };
            MyClass x2 = new MyClass() { FirstName = "Michael" };

            Console.WriteLine(x.FirstName);
            Console.WriteLine(x2.FirstName);
            Console.WriteLine(MyClass.Name);

            MyClass.Name = "Dulki";

            Console.WriteLine(MyClass.Name);

            Singleton.Instance.DoSomething();
        }
    }
}