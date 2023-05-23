namespace Generics
{
    public class MyList<T> 
    {
        private T[] Values { get; set; } = new T[0];
        public int Count => Values.Length;

        public void Add(T item)
        {
            Values = Values.Concat(new[] { item }).ToArray();
        }

        public void Remove(T item)
        {
            Values = Values.Where(x => !x.Equals(item)).ToArray();
        }

        public void PrintValues()
        {
            Console.WriteLine();

            foreach (T e in Values)
            {
                Console.Write(e + "  ");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            list.Add(3);
            list.Add(9);
            list.Add(5);
            list.Add(7);
            list.Add(9);
            list.Remove(9);

            Console.WriteLine($"List contains {list.Count} elements");
            list.PrintValues();
            Console.ReadKey();

            MyList<string> list2 = new MyList<string>();
            list2.Add("asdas");
            list2.Add("10");
            list2.Add("fgdfs");
            list2.Remove("fgdfs");

            list2.PrintValues();
            Console.ReadKey();

            List<double> list3 = new List<double>();

            list3.Add(10.5);
            list3.Add(20.5);
            list3.Add(30.5);

            foreach (var item in list3)
            {
                Console.WriteLine(item + " ");
            }
        }

        //static void Print(int a)
        //{
        //    Console.WriteLine(a.ToString());
        //}

        //static void Print(double a)
        //{
        //    Console.WriteLine(a.ToString());
        //}

        //static void Print(bool a)
        //{
        //    Console.WriteLine(a.ToString());
        //}

        //static void PrintGeneric<T>(T a)
        //{
        //    Console.WriteLine(a.ToString());
        //}
    }
}