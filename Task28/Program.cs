// Задача 28: Напишите программу, которая принимает на
// вход  число N и выдает произведение чисел
// от 1 до А
// 5 -> 24
// 5 -> 120


int SumProiz(int num)
{
    int pro = 1;
    for (int i = 1; i <= num; i++)
    {
        // sum = sum + 1;
        pro *= i;
    }
    return pro;
}

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
int result = SumProiz(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {result}");
