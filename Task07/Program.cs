// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите трехзначное число");
int number1 = Convert.ToInt32(Console.ReadLine());

if (number1 < 0)
{
    number1 *= -1;
}

if (number1 >= 100 & number1 <= 999)
{
    int res = number1 % 10;
    Console.WriteLine($"Последняя цифра {res}");
}
else
{
    Console.WriteLine("Не корректный ввод");
}