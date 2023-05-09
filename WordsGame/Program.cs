namespace ConsoleApp1
{
    internal class Program
    {
        static Random rand = new Random();

        static void Main(string[] args)
        {
            List<string> words = File.ReadAllLines("words.txt").ToList();
            List<string> selection = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                int index = rand.Next(0, words.Count);
                selection.Add(words[index]);
                words.RemoveAt(index);
            }
            List<double> timeList = new List<double>();

            foreach (string word in selection)
            {
                double time = EnterWord(word);
                timeList.Add(time);
            }
            double average = Math.Round(timeList.Average(), 2);
            Console.WriteLine($"Your average time is: {average}s");

            Console.ReadKey();
        }

        static double EnterWord(string word)
        {
            string s = "";
            DateTime start = default;

            while (s != word)
            {
                Console.Clear();
                Console.WriteLine($"Type \" {word} \" as fast as you can and press Enter after each word:\r\n\r\n");
                start = DateTime.Now;
                s = Console.ReadLine();
            }
            return (DateTime.Now - start).TotalSeconds;
        }
    }
}