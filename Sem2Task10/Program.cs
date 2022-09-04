// 10 Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

void MyVariant() // вариант работает только с трехзначными числами 
{
    Console.WriteLine("Введите трехзначное число");
    string? inputLine = Console.ReadLine();

    if (inputLine != null)
    {
        int inputNumber = int.Parse(inputLine);
        if (inputNumber > 99 && inputNumber < 1000)
        {
            int secondDigit = (inputNumber % 100) / 10;
            Console.Write(secondDigit);
        }
        else
        {
            Console.WriteLine("Вы ввели не трехзначное число");
        }
    }
}
MyVariant();

void CharVariant() // вариант со звездочкой*
{
    Console.WriteLine("Введите любое положительное целое число");
    string? inputLine = Console.ReadLine();

    if (inputLine != null)
    {
        int inputNumber = int.Parse(inputLine);
        char[] charArray = inputNumber.ToString().ToCharArray();
        Console.WriteLine(charArray[1]);
    }
}
CharVariant();