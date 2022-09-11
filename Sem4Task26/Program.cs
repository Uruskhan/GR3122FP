// Напишите программу, которая принимает на вход
// число и выдаёт количество цифр в числе

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int CalculateData(int numberA)
{
    char[] array = numberA.ToString().ToCharArray();
    int numOfDigits = array.Length;
    return numOfDigits;
} 

// int CalculateAP(int numberA) // арифметическая прогрессия
// {
//     int sumA = numberA * (numberA + 1) / 2;
//     return sumA;
// }

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int numA = ReadData("Введите число: ");

DateTime d1 = DateTime.Now;
CalculateData(numA);
Console.WriteLine(DateTime.Now-d1);

// DateTime d2 = DateTime.Now;
// CalculateAP(numA);
// Console.WriteLine(DateTime.Now-d2);

int result1 = CalculateData(numA);
// int result2 = CalculateAP(numA);

PrintResult("В числе " + numA + " всего "+ result1 + " цифр");
// PrintResult("Сумма чисел от 1 до " + numA + ": " + result2);