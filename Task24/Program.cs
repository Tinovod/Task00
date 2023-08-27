// Задача 24: Напишите программу, которая принимает на
// вход пятизначное число А и выдает сумму чисел
// от 1 до А
// 7 -> 28
// 4 -> 10
// 8 -> 36

int SumNumber(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        // sum = sum + 1;
        sum += i;
    }
    return sum;
}

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
int result = SumNumber(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {result}");
