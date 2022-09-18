// Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных
// элементов массива.

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int[] FillArray(int arrLen, int downBorder, int topBorder)
{
    Random rand = new Random();

    int[] array = new int[arrLen];

    if (downBorder < topBorder)
    {
        for (int i = 0; i < arrLen; i++)
        {
            array[i] = rand.Next(downBorder, topBorder);
        }
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
}

int[] NegativeAndPositiveSum(int[] arr)
{
    int[] sums = new int[2];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
        {
            sums[0] = sums[0] + arr[i];
        }
        else
        {
            sums[1] = sums[1] + arr[i];
        }
    }
    return sums;
}


int num = ReadData("Введите число: ");
int downBorder = ReadData("Введите нижнюю границу: ");
int topBorder = ReadData("Введите верхнюю границу: ");

DateTime d1 = DateTime.Now;
FillArray(num, downBorder, topBorder);
Console.WriteLine(DateTime.Now - d1);

int[] result1 = FillArray(num, downBorder, topBorder);
int[] result2 = NegativeAndPositiveSum(result1);

PrintArray(result1);
PrintArray(result2);