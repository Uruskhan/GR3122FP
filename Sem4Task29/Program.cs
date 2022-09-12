// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int[] GenArray(int arrLen, int rangeStart, int rangeEnd)
{
    int[] array = new int[arrLen];
    Random rand = new Random();
    int i = 0;
    for (i = 0; i < arrLen; i++)
    {
        array[i] = rand.Next(rangeStart, rangeEnd);
    }
    return array;
}

void PrintArray(int[] array)
{
    int i = 0;
    for (i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
}

int num = ReadData("Введите длину массива: ");
int num1 = ReadData("Введите начало диапазона значений массива: ");
int num2 = ReadData("Введите конец диапазона значений массива: ");

DateTime d1 = DateTime.Now;
GenArray(num, num1, num2);
Console.WriteLine(DateTime.Now - d1);

int[] result = GenArray(num, num1, num2);

PrintArray (result);