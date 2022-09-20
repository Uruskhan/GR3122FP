// Задайте одномерный массив, заполненный случайными числами. Найдите сумму
// элементов, стоящих на нечётных позициях.
// * Найдите все пары в массиве и выведите пользователю

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

long EvenSumFinder(int[] array)
{
    long sumEvenNum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1) sumEvenNum = sumEvenNum + array[i];
    }
    return sumEvenNum;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int[,] PairsArray(int[] arr) //метод принимает на вход массив и выводит двумерный массив из пар
{
    int[,] newArr = new int[arr.Length / 2, arr.Length]; // выделяем память для нового массива с двумя столбцами и количеством строк в половину длины искомого массива

    for (int i = 0; i < arr.Length / 2; i++) // цикл заполняет массив 
    {
        Console.WriteLine(newArr[arr[i], arr[arr.Length - 1 - i]]);
    }
    return newArr;
}

void Print2DArray(int[,] array) // принимает на вход двумерный массив и выводит на экран
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[] arr = GenArray(8, 0, 10);
PrintArray(arr);
PrintResult("Сумма всех нечетных элементов массива: " + EvenSumFinder(arr));

int[,] newArray = PairsArray(arr);
Print2DArray(newArray);