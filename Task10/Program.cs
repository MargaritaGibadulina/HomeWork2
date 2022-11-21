/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

int number = ReadInt("Введите число: ");
if(number > 99)
{
    if(number < 1000)
    {
        int digitTwo = (number / 10) % 10;
        Console.WriteLine($"Вторая цифра введённого числа {digitTwo}");
    }
}
if (number <= 100 || number > 999) 
{
    Console.WriteLine("Число не трёхзначное");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}