// ввод чисел
int[] mas = { 5, 6, 3, 7, 1 };

// сортировка
int temp;
for (int i = 0; i < mas.Length-1; i++)
{
for (int j = i + 1; j < mas.Length; j++)
{
Console.WriteLine($"i = {i} и j = {j}");
Console.WriteLine("Текущее состояние массива: "+ String.Join(",",mas));
Console.WriteLine($"Сравниваем mas[i] = {mas[i]} и mas[j] = {mas[j]}");
if (mas[i] > mas[j])
{
Console.WriteLine("mas[i] больше mas[j]");
Console.WriteLine($"Работаем с : mas[i] = {mas[i]} и mas[j] = {mas[j]}");
temp = mas[i];
mas[i] = mas[j];
mas[j] = temp;
Console.WriteLine($"Поменяли местами, теперь : mas[i] = {mas[i]} и mas[j] = {mas[j]} ");
}
else
{
Console.WriteLine("mas[i] меньше mas[j], продолжаем итерации");
}
}
}

// вывод
Console.WriteLine("Вывод отсортированного массива");
for (int i = 0; i < mas.Length; i++)
{
Console.WriteLine(mas[i]);
}
Console.ReadLine();