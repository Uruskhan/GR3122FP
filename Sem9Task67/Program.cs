int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int RecSumdig(int numN)
{
    if (numN == 0) return 0; //точка остановки
    int outline = RecSumdig(numN / 10) + numN % 10;
    return outline;
}

int numB = ReadData("ВВедите число: ");
int resultLine = RecSumdig(numB);
PrintResult("Сумма цифр введенного числа: " + resultLine);