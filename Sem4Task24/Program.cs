// написать программу которая на вход получает число A
// и на выходе выводит таблицу сумму всех чисел от единицы до А

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int CalculateData(int numberA)
{
    int i = 1;
    int sumA = 0;
    while (i <= numberA)
    {
        sumA = sumA + i;
        ++i;
    }
    return sumA;
}

int CalculateAP(int numberA) // арифметическая прогрессия
{
    int sumA = numberA * (numberA + 1) / 2;
    return sumA;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int numA = ReadData("Введите число: ");

DateTime d1 = DateTime.Now;
CalculateData(numA);
Console.WriteLine(DateTime.Now-d1);

DateTime d2 = DateTime.Now;
CalculateAP(numA);
Console.WriteLine(DateTime.Now-d2);

int result1 = CalculateData(numA);
int result2 = CalculateAP(numA);

PrintResult("Сумма чисел от 1 до " + numA + ": " + result1);
PrintResult("Сумма чисел от 1 до " + numA + ": " + result2);