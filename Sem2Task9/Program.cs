void MyVariant()
{
    System.Random numberGenerator = new System.Random();

    int number = numberGenerator.Next(10, 100);

    Console.WriteLine(number);

    int firstDigit = number / 10;

    int secondDigit = number % 10;

    if (firstDigit > secondDigit)
    {
        Console.WriteLine(firstDigit);
    }
    else
    {
        Console.WriteLine(secondDigit);
    }
}
// Вариант Евгения
void EvgeniyVariant()
{
    System.Random numberGenerator = new System.Random();

    int number = numberGenerator.Next(10, 100);

    Console.WriteLine(number);
    
    int firstDigit = number / 10;

    int secondDigit = number % 10;

    Console.WriteLine((firstDigit > secondDigit) ? firstDigit : secondDigit);
}
// Вариант char
MyVariant();