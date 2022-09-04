// Напишите программу, которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа 

void GolikovVariant()
{
    Console.WriteLine("Метод Голикова");
    System.Random numberGenerator = new System.Random();

    int number = numberGenerator.Next(100, 1000);

    Console.WriteLine(number);

    int firstDigit = number / 100;

    int thirdDigit = number % 10;

    Console.WriteLine(firstDigit * 10 + thirdDigit);

}
GolikovVariant();

void KonstantinVariant()
{
    Console.WriteLine("Метод Konstantina");
    System.Random numberGenerator = new System.Random();

    int number = numberGenerator.Next(100, 1000);

    Console.WriteLine(number);

    char[] array = number.ToString().ToCharArray();

    Console.WriteLine(array[0]+""+array[2]);

}
KonstantinVariant();

