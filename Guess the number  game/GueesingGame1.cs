
namespace Guess_the_number__game
{
    class GueesingGame1
    {
        public int RandomNumber { get; set; }
     
        public void Start()
        {
            Random random = new Random();
            RandomNumber = random.Next(1, 101);
        }

        public int CheckUserInput(int number) 
        {
            if (number == RandomNumber)
            {
                return 0;
            }
            if (number > RandomNumber)
            {
                return 1;
            }
            return -1;
        }

        public void Finish()
        {
            Console.WriteLine();
            Console.WriteLine($"You won! The was thinking about {RandomNumber}");

        }
    }
}
