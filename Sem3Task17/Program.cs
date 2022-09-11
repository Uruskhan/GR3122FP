int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int QuarterTest(int x, int y)
{
    if (x > 0 && y > 0)
        return 1;
    if (x < 0 && y > 0)
        return 2;
    if (x < 0 && y < 0)
        return 3;
    if (x > 0 && y < 0)
        return 4;

        return -1;
}
void PrintResult(string line)
{
    Console.WriteLine(line);
}

int x = ReadData("Введите координату Х: ");
int y = ReadData ("Введите координату Y: ");

int res = QuarterTest(x,y);

PrintResult("Точка находится в четверти №:" + res);