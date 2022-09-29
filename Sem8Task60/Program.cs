// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Создание 3D массива.
int[,,] Gen3DArray(int dim1, int dim2, int dim3, int minValue, int maxValue)
{
    int[,,] array = new int[dim1, dim2, dim3];
    Random rand = new Random();
    for (int i = 0; i < dim1; i++)
    {
        for (int j = 0; j < dim2; j++)
        {
            for (int k = 0; k < dim3; k++)
            {
                array[i, j, k] = rand.Next(minValue, maxValue);
            }
        }
    }
    return array;
}

// Создание 3D массива с неповторяющимися элементами
int[,,] Gen3DDiffArray(int dim1, int dim2, int dim3)
{
    int[,,] array = new int[dim1, dim2, dim3];
    List<int> numbers = Enumerable.Range(10, 99).ToList(); // создаем список возможных элементов 3Д массива
    Random rand = new Random();
    for (int i = 0; i < dim1; i++)
    {
        for (int j = 0; j < dim2; j++)
        {
            for (int k = 0; k < dim3; k++)
            {
                int indOfNum = rand.Next(numbers.Count); // случайным образом выбираем индекс элемента из массива List
                array[i, j, k] = numbers[indOfNum]; // присваиваем 
                numbers.RemoveAt(indOfNum); // исключаем соответствующий элемент из массива
            }
        }
    }
    return array;
}

// Печать 3D массива.
void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k})\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] arr1 = Gen3DArray(2, 2, 2, 10, 99);
int[,,] arr2 = Gen3DDiffArray(2, 2, 2);
Console.WriteLine("Простая печать 3D массива:");
Print3DArray(arr1);
Console.WriteLine("3D массив с неповторяющимися элементами:");
Print3DArray(arr2);