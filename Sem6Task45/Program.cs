// Напишите программу, которая будет создавать
// копию заданного одномерного массива с помощью
// поэлементного копирования.

int[] GenArray(int arrLen, int minArr, int maxArr) // генерируем массив с заданной длиной
{
    int[] array = new int[arrLen]; // выделяем память для нового массива с заданной длиной 
    Random rand = new Random(); // пока не знаю как правильно это закомментить 

    for (int i = 0; i < arrLen; i++)
    {
        array[i] = rand.Next(minArr, maxArr); // заполняем массив случайными числами
    }
    return array; // возвращаем массив
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

int[] CopyArray(int[] array)
{
    int[] outArray = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        outArray[i] = array[i];
    }
    return outArray;
}

int[] arr = GenArray(10, 30, 100);
PrintArray(arr);
PrintArray(CopyArray(arr));

PrintArray((int[])arr.Clone());
