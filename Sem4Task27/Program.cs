// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в
// числе

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int CalculateData(int numberA)
{
    int sumOfDigits = 0;
    while (numberA % 10 > 0)
    {
        sumOfDigits = sumOfDigits + numberA % 10;
        numberA = numberA / 10;
    }
    return sumOfDigits;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int numA = ReadData("Введите число: ");

DateTime d1 = DateTime.Now;
CalculateData(numA);
Console.WriteLine(DateTime.Now - d1);

int result = CalculateData(numA);

PrintResult("Сумма цифр числа " + numA + " равна " + result);
