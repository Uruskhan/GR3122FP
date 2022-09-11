// Напишите программу, которая принимает на вход 
// любое число и проверяет, является ли оно палиндромом.

long ReadData(string line)
{
    Console.WriteLine(line);
    long number = long.Parse(Console.ReadLine() ?? "0");
    return number;
}

// метод работает только с пятизначными числами
bool numberTest(long numberN)
{
    if (numberN > 9999 && numberN < 100000 && numberN / 10000 == numberN % 10 && (numberN / 1000) % 10 == (numberN % 100) / 10)
    {
        return true;
    }
    else
    {
        return false;
    }
}

// метод с разворотом массива, работает с числами любой длины
bool polindromTest(long numberN)
{
    char[] arrayN = numberN.ToString().ToCharArray(); //превращаем полученное число в массив
    Array.Reverse(arrayN);
    long reversedArray = long.Parse(arrayN);

    if (reversedArray == numberN)
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

long num = ReadData("Введите число: ");

DateTime d1 = DateTime.Now;
polindromTest(num);
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
numberTest(num);
Console.WriteLine(DateTime.Now - d2);

bool result1 = polindromTest(num);
bool result2 = numberTest(num);

PrintResult(result1 == true ? "Число " + num + " является палиндромом" : "Число " + num + " не является палиндромом");
PrintResult(result2 == true ? "Число " + num + " является палиндромом" : "Число " + num + " не является палиндромом");