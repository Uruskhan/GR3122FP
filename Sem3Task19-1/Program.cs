// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом (через словарь)

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

Dictionary<int, int> GenerateDicOf4DigitPolindroms()
{
    Dictionary<int, int> polindrom = new Dictionary<int, int>();
    for (int i = 10; i < 100; i++)
    {
        polindrom.Add((100 * i + i % 10 * 10 + i / 10), 0);
        Console.WriteLine((100 * i + i % 10 * 10 + i / 10));
    }
    return polindrom;
}

bool TestPoliHash(int numberP, Dictionary<int, int> dict)
{
    int numberToCompare = numberP / 1000 * 100 + numberP % 100;
    if (dict.ContainsKey(numberToCompare))
    {
        
        return true;
    }
    else
    {
        return false;
    }
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int num = ReadData("Введите пятизначное число: ");
Dictionary<int, int> polindrom = GenerateDicOf4DigitPolindroms();

bool result = TestPoliHash(num, polindrom);

PrintResult(result == true ? "Число " + num + " является палиндромом" : "Число " + num + " не является палиндромом");