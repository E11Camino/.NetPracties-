using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace ConsoleApp1
{
    class MyClass
    {
        public string FirstName { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // anonymous types
            var myClass = new MyClass() { FirstName = "Michael" };

            var anonymous = new
            {
                aaa = "bbb"
            };
            string json1 = JsonConvert.SerializeObject(myClass);
            string json2 = JsonConvert.SerializeObject(anonymous);

            // Console.WriteLine(json1);
            // Console.WriteLine(json2);

            Func<int, int, int> f1 = new Func<int, int, int>(Sum);
            Func<int, int, int> f2 = (a, b) => a * b;  // (a, b) => a * b
            Action<int> f3 = a => Console.WriteLine(a);

            Console.WriteLine(f1(3, 5));
            Console.WriteLine(f2(3, 5));
            f3(100);
        }

        static int Sum(int a, int b) => a + b;
    }
}