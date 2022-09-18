// Задайте одномерный массив из 123 случайных
// чисел. Найдите количество элементов массива,
// значения которых лежат в отрезке [10,99].

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int[] GenArray(int arrLen, int downBorder, int topBorder)
{
    Random rand = new Random();

    int[] array = new int[arrLen];

    if (downBorder > topBorder) // проверка на дурака
    {
        int temp = topBorder;
        topBorder = downBorder;
        downBorder = temp;
    }

    for (int i = 0; i < arrLen; i++)
    {
        array[i] = rand.Next(downBorder, topBorder);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length-1]);
    Console.WriteLine();
}

int countNumber(int[] arr, int min, int max)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= min && arr[i] <= max) count++;
    }
    return count;
}

// int num = ReadData("Введите длину одномерного массива: ");
// int minArr = ReadData("Введите нижнюю границу: ");
// int maxArr = ReadData("Введите верхнюю границу: ");

int min = ReadData("Введите нижнюю границу искомого интервала: ");
int max = ReadData("Введите верхнюю границу искомого интервала: ");

int[] result1 = GenArray(123, 1, 1000);
int result2 = countNumber(result1, min, max);

PrintArray(result1);
Console.WriteLine("Количество элементов массива попадающих в заданный отрезок: " + result2);
