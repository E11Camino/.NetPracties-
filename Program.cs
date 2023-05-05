using Practies;

UserInputValidator userInputValidator = new UserInputValidator();

UserInput userInput = new UserInput();
userInput.Name = GetName();
userInput.Age = GetAge();
userInput.Color = GetColor();
userInput.PrintInformation();


string GetName()
{
    Console.WriteLine("Please enter your name:");
    string input = Console.ReadLine();

    while (!userInputValidator.IsNameValid(input))
    {
        ShowError();
        input = Console.ReadLine();
    }
    return input;
}

int GetAge()
{
    Console.WriteLine("Please enter your age:");
    string input = Console.ReadLine();
    int age = 0;

    while (!userInputValidator.TryParseAge(input, out age))
    {
        ShowError();
        input = Console.ReadLine();
    }
    return age;
}

    Colors GetColor()
{
    Console.WriteLine("Please enter your favorite color:");
    string input = Console.ReadLine();
    Colors color = default;

    while (!userInputValidator.TryParseColor(input, out color))
    {
        ShowError();
        input = Console.ReadLine();
    }
    return color;
}

void ShowError()
{
    Console.WriteLine("Enter valid value");
    Thread.Sleep(1000);
    Console.CursorTop -= 2;
    Console.CursorLeft = 0;
    Console.WriteLine(new String(' ', 50));
    Console.WriteLine(new String(' ', 50));
    Console.CursorTop -= 2;
}