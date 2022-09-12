// Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

long CalculateData(int number)
{
    int i = 1;
    long multOfNumbers = 1;
    while (i <= number)
    {
        multOfNumbers = multOfNumbers * i;
        i++;
    }
    return multOfNumbers;
}

long CalculateByRec(int number)
{
    if (number == 1)
        return 1;
    return number * CalculateByRec(number - 1);
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int num = ReadData("Введите число: ");

DateTime d1 = DateTime.Now;
CalculateData(num);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
CalculateByRec(num);
Console.WriteLine(DateTime.Now - d2);

long result1 = CalculateData(num);
long result2 = CalculateByRec(num);

PrintResult("Метод факториал. Произведение чисел от 1 до " + num + " равно " + result1);
PrintResult("Метод рекурсии. Произведение чисел от 1 до " + num + " равно " + result2);