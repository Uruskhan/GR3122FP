int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

string QuarterBorderAsk(int numQuater)
{
    if (numQuater == 1)
        return "x > 0, y > 0";
    if (numQuater == 2)
        return "x < 0, y > 0";
    if (numQuater == 3)
        return "x < 0, y < 0";
    if (numQuater == 4)
        return "x > 0, y < 0";

    return "";
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int num = ReadData("Введите номер четверти: ");

string res = QuarterBorderAsk(num);

PrintResult(res);