/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

int dayNumber = ReadInt("Введите число: ");

if (dayNumber >= 1 && dayNumber <=5)
{
    Console.WriteLine("Нет, это не выходной");
}
else if (dayNumber >= 6 && dayNumber <= 7)
{
    Console.WriteLine("Да, это выходной");
}
else 
{
    Console.WriteLine("Не существует такого дня недели");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}