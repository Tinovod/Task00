// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


int number = new Random().Next(0, 100); //получим рандомные числа от 10 до 100
Console.WriteLine($"Случайное число из диапозона от 0 до 100000 --> {number}");


if (number < 100)
Console.WriteLine("Третьей цифры нет");
else
{
    while (number > 999)
    number = number / 10;
    number = number % 10;
    Console.WriteLine(number);
}
      


