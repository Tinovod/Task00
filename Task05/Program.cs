// 5. Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
int count = -number1;
while (count <= number1)
{
    Console.Write($"{count} ");
    count++;
}