using Lessons_practies_1;

BankAccount newAccount = new BankAccount(734455,754,"EU 753/87");

newAccount.PrintInfo();

Console.ReadKey();

Console.WriteLine();

Dog newDog = new Dog()
{
    Age =  1.5,
    Color = "White",
    Breed = "Samoed",
    Sex = "Sukka"
};

newDog.DogInfo();
newDog.DogSays();

Console.ReadKey();


