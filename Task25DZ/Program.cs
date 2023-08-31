// Задача 25: Напишите программу, 
// которая принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// Алгоритм нужно реализовать самостоятельно, 
// встроенную функцию использовать нельзя.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень числа А: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = 1;
for (int i = 0; i < b; i++)
{
   result *= a; 
}

Console.WriteLine($"Число {a} в степени {b} = {result}");