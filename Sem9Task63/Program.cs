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

string LineGenRec(int numN)
{
    if (numN == 0) return ""; //точка остановки
    string outline = LineGenRec(numN - 1) + " " + numN;
    return outline;
}

// 1 4
// 2
// 3
// 4
// 5

int numB = ReadData("ВВедите число: ");
string resultLine = LineGenRec(numB);
PrintResult(resultLine);