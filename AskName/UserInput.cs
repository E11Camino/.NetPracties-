namespace Practies
{
    internal class UserInput
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Colors Color { get; set; }

        public void PrintInformation()
        {
            Console.WriteLine();
            Console.WriteLine("Your Name: {0}", Name);
            Console.WriteLine("Your Age: {0}", Age);
            Console.WriteLine("Your favorite color: {0}", Color);
        }
    }
}