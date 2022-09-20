// Напишите программу, которая принимает на вход
// три числа и проверяет, может ли существовать
// треугольник с сторонами такой длины

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void PrintResult(string prefix, string data)
{
    Console.WriteLine(prefix + data);
}

// метод Андрея
string FibNum(int num)
{
    string result = string.Empty;
    int first = 0;
    int last = 1;
    int temp = 0;
    for (int i = 0; i < num; i++)
    {
        result = result + " " + first;
        temp = first + last;
        first = last;
        last = temp;
    }
    return result;
}
// метод Константина
int[] FibbonachiArray(int num)
{
    int[] array = new int[num];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < num; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

void PrintArray(int[] array) // принимает на вход массив и выводит на экран
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
    Console.WriteLine();
}


int num = ReadData("Введите количество чисел Фиббоначи: ");
string line = FibNum(num);
PrintResult("Числа Фиббоначи: ", line);

PrintArray(FibbonachiArray(num));
