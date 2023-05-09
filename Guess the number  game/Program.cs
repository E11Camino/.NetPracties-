
using Guess_the_number__game;

GueesingGame1 gueesingGame = new GueesingGame1();

bool isValidInput = false;
string userInput = "";

while (!isValidInput)
{
    Console.Clear();
    Console.WriteLine("Hi, let's play an inteesting game!");
    Console.WriteLine("Ready?");
    userInput = Console.ReadLine().ToLower();

    if (userInput == "yes")
    {
        isValidInput = true;    
        Console.WriteLine("Let Go!");
        Console.WriteLine("I'm thinking of a number between 1 and 100. Can you guess what it is the number?");
    }
    else if (userInput == "no")
    {
        isValidInput = true;
        Console.WriteLine("OK! Than next time");
        Console.WriteLine("Good Bye!");
        Console.ReadKey();
        return;
    }
    else
    {
        Console.WriteLine("Can't get it. Please enter 'Yes' or 'No'");
        Thread.Sleep(4000);
    }
}

gueesingGame.Start();
Console.WriteLine("Please enter your guess number from 1 to 100):");

InputValidator validator = new InputValidator();   

while (true)
{
    userInput = Console.ReadLine();

    if (!validator.TryParseInputNumber(userInput, out int parsed) || parsed < 0 || parsed > 100)
    {
        Console.WriteLine("Please enter a valid number from 1 to 100");
        continue;
    }

    int checkResult = gueesingGame.CheckUserInput(parsed);

    if (checkResult == 0)
    {
        Console.WriteLine($"You won! The was thinking about {gueesingGame.RandomNumber}");
        break;
    }
    else if (checkResult > 0)
    {
        Console.WriteLine("Too high, try again.") ;
    }
    else
    {
        Console.WriteLine("Too low, try again.");
    }
}



Console.ReadKey();




