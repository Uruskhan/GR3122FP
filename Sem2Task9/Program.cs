// 9 Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа

// Вариант Голикова
void MyVariant()
{
    Console.WriteLine ("Метод Голикова");
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
    Console.WriteLine ("Метод Евгения");
    System.Random numberGenerator = new System.Random();

    int number = numberGenerator.Next(10, 100);

    Console.WriteLine(number);

    int firstDigit = number / 10;

    int secondDigit = number % 10;

    Console.WriteLine((firstDigit > secondDigit) ? firstDigit : secondDigit);
}

// Вариант char
void charVariant()
{
    Console.WriteLine ("Метод Char");
    System.Random numberGenerator = new System.Random();

    int number = numberGenerator.Next(10, 100);

    Console.WriteLine(number);

    char[] charArray = number.ToString().ToCharArray();

    Console.WriteLine(((int)charArray[0] > (int)charArray[1]) ? charArray[0] : charArray[1]);
}

MyVariant();
EvgeniyVariant();
charVariant();