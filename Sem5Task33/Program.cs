// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в
// массиве.

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

bool findNumber(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num) return true;
    }
    return false;
}

int num = ReadData("Введите число: ");
int downBorder = ReadData("Введите нижнюю границу: ");
int topBorder = ReadData("Введите верхнюю границу: ");
int number = ReadData("Введите искомое число: ");

DateTime d1 = DateTime.Now;
FillArray(num, downBorder, topBorder);
Console.WriteLine(DateTime.Now - d1);

int[] result1 = FillArray(num, downBorder, topBorder);
bool result2 = findNumber(result1, number);

PrintArray(result1);
Console.WriteLine((result2 == true) ? "Искомое число содержится в массиве" : "Искомое число в массиве отсутствует");