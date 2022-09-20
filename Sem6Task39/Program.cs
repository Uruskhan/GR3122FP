// Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на
// первом месте, а первый - на последнем и т.д.)

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

int[] SwapNewArray(int[] arr) // разворот массива с созданием нового 
{
    int[] outArray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        outArray[i] = arr[arr.Length - 1 - i];
    }
    return outArray;
}

int[] SwapArray(int[] arr) // разворот массива с временной переменной 
{
    int temp = 0;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        temp = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = arr[i];
        arr[i] = temp;
    }
    return arr;
}

int[] SwapSimpleArray(int[] arr) // разворот массива встроенными инструментами
{
    arr.Reverse();
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
    Console.WriteLine();
}

int[] array = GenArray(20, 1, 100);
Console.WriteLine("Исходный массив");
PrintArray(array);

Console.WriteLine("Скорости разворота различными методами:");
DateTime d1 = DateTime.Now;
PrintArray(SwapNewArray(array));
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
PrintArray(SwapArray(array));
Console.WriteLine(DateTime.Now - d2);

DateTime d3 = DateTime.Now;
PrintArray(SwapSimpleArray(array));
Console.WriteLine(DateTime.Now - d3);