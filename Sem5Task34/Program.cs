// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// * Отсортировать массив методом пузырька


int[] GenArray(int arrLen, int downBorder, int topBorder) // генерируем массив с заданными длиной и границами
{
    if (downBorder > topBorder) // меняем местами границы, если вдруг введены в обратном порядке 
    {
        int temp = topBorder;
        topBorder = downBorder;
        downBorder = temp;
    }

    int[] array = new int[arrLen]; // выделяем память для нового массива с заданной длиной 
    Random rand = new Random(); // пока не знаю как правильно это закомментить 

    for (int i = 0; i < arrLen; i++)
    {
        array[i] = rand.Next(downBorder, topBorder);
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

int CalculateEvenNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

int[] BubbleSortArray(int[] array) // Сортировка пузырьком
{
    for (int j = 0; j < array.Length-1; j++)
    {
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[i - 1])
            {
                int temp = array[i];
                array[i] = array[i - 1];
                array[i - 1] = temp;
            }
        }
    }
    return array;
}

int[] arr = GenArray(10, 100, 1000);
PrintArray(arr);
Console.WriteLine("В заданном массиве четных чисел: " + CalculateEvenNum(arr));

PrintArray(BubbleSortArray(arr));
