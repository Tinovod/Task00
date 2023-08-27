﻿// Напишите программу, которая 
// 1. принимает на вход
// координаты точки (X, Y), причем они не равны 0
// 2. выдает номер четверти плоскости, в которой 
// находится эта точка

int Quarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
    
}

Console.WriteLine ("Введите координаты точки");
Console.Write("X: ");
int xCordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCordinate = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xCordinate, yCordinate);
string result = quarter > 0 
    ? $"Указанные координаты соответствуют четверти  -> {quarter}" 
    : "Введены некорректные координаты";
Console.WriteLine(result);