// Напишите программу, которая выводит массив из 8
// элементов, заполненный нулями и единицами в
// случайном порядке.

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int[] GenArray(int arrLen)
{
    int[] array = new int[arrLen];
    Random rand = new Random();
    int i = 0;
    for (i = 0; i < arrLen; i++)
    {
        array[i] = rand.Next(0, 2);
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

int num = ReadData("Введите число: ");

DateTime d1 = DateTime.Now;
GenArray(num);
Console.WriteLine(DateTime.Now - d1);

int[] result = GenArray(num);

PrintArray (result);