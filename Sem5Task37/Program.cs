// Найдите произведение пар чисел в одномерном
// массиве. Парой считаем первый и последний
// элемент, второй и предпоследний и т.д. Результат
// запишите в новом массиве.


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

int[] multNumArray(int[] arr)
{
    int[] newArr = new int[arr.Length/2];

    for (int i = 0; i < arr.Length/2; i++)
    {
        newArr[i] = arr[i]*arr[arr.Length-1-i];
    }
    return newArr;
}

int num = ReadData("Введите длину одномерного массива: ");
int minArr = ReadData("Введите нижнюю границу: ");
int maxArr = ReadData("Введите верхнюю границу: ");

// int min = ReadData("Введите нижнюю границу искомого интервала: ");
// int max = ReadData("Введите верхнюю границу искомого интервала: ");

int[] result1 = GenArray(num, minArr, maxArr);
int[] result2 = multNumArray(result1);

PrintArray(result1);
PrintArray(result2);

// Console.WriteLine("Количество элементов массива попадающих в заданный отрезок: " + result2);
