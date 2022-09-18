// Задайте массив вещественных чисел. Найдите разницу между максимальным и
// минимальным элементов массива.

// * Отсортируйте массив методом вставки и методом подсчета, а затем найдите
// разницу между первым и последним элементом. Для задачи со звездочкой
// использовать заполнение массива целыми числами.

double[] GenArray(int arrLen, int minArr, int maxArr) // генерируем массив с заданной длиной
{
    double[] array = new double[arrLen]; // выделяем память для нового массива с заданной длиной 
    Random rand = new Random(); // пока не знаю как правильно это закомментить 

    for (int i = 0; i < arrLen; i++)
    {
        array[i] = rand.Next(minArr, maxArr); // заполняем массив случайными числами
    }
    return array; // возвращаем массив
}

void PrintArray(double[] array) // принимает на вход массив и выводит на экран
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
    Console.WriteLine();
}

void PrintResult(string line) //
{
    Console.WriteLine(line);
}

double MinMaxDifFinder(double[] array) //нахождение разницы между минимальным и максимальным элементом массива
{
    double diff = array.Max() - array.Min();
    return diff;
}

// сортировка массива методом вставки
double[] InsertSort(double[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = i + 1; j > 0; j--) // цикл работает до момента достижения j = 0
        {
            if (arr[j] < arr[j - 1]) // если тот элемент, который мы хотим переставить меньше элемента, расположенного слева от него, то
            {
                double temp = arr[j];
                arr[j] = arr[j - 1]; // меняем их местами
                arr[j - 1] = temp;
            }
        }
    }
    return arr;
}

// сортировка массива методом выбора
double[] SelectSort(double[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] > arr[j]) // если элемент arr[j], который мы хотим переставить меньше элемента arr[i], расположенного слева от него, то
            {
                double temp = arr[i];
                arr[i] = arr[j]; // меняем их местами
                arr[j] = temp; 
            }
        }
    }
    return arr;
}

// сортировка массива методом пузырьков
double[] BubleSort(double[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = 1; j < arr.Length; j++) // 
        {
            if (arr[j] < arr[j-1]) // если тот элемент, который мы хотим переставить меньше элемента, расположенного слева от него, то
            {
                double temp = arr[j-1];
                arr[j-1] = arr[j]; // меняем их местами
                arr[j] = temp;
            }
        }
    }
    return arr;
}


double[] arr = GenArray(10, 30, 100);
PrintArray(arr);
PrintResult("Разница между минимальным и максимальным элементом массива: " + MinMaxDifFinder(arr));

DateTime d1 = DateTime.Now;
PrintArray(SelectSort(arr));
Console.WriteLine(DateTime.Now - d1);

DateTime d2 = DateTime.Now;
PrintArray(InsertSort(arr));
Console.WriteLine(DateTime.Now - d2);

DateTime d3 = DateTime.Now;
PrintArray(BubleSort(arr));
Console.WriteLine(DateTime.Now - d3);