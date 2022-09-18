// Напишите программу замена элементов массива:
// положительные элементы замените на
// соответствующие отрицательные, и наоборот.

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
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
}

int[] changeArray(int[] arr)
{
    int[] arrNew = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
        arrNew[i] = arr[i] * -1;
    return arrNew;
}

int num = ReadData("Введите число: ");
int downBorder = ReadData("Введите нижнюю границу: ");
int topBorder = ReadData("Введите верхнюю границу: ");

DateTime d1 = DateTime.Now;
FillArray(num, downBorder, topBorder);
Console.WriteLine(DateTime.Now - d1);

int[] result1 = FillArray(num, downBorder, topBorder);
int[] result2 = changeArray(result1);

PrintArray(result1);
PrintArray(result2);