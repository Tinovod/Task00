// Напишите программу, которая 
// 1. принимает на вход номер четверти
// 
// 2. выдает координаты четверти плоскости, в которой 
// находится эта точка

string RangeCoordinat(int quart)
{
    if (quart == 1) return x > 0 && y > 0;
    if (quart == 2) return x < 0 && y > 0;
    if (quart == 3) return x < 0 && y < 0;
    if (quart == 4) return x > 0 && y < 0;
    return null;
}

Console.WriteLine ("Введите номер четверти");
int quarter = Convert.ToInt32(Console.ReadLine());

string rangeCoordinat = RangeCoordinat(quarter);
string result = rangeCoordinat != null ? rangeCoordinat 
                                                : "Введена некорректная четверть";
Console.WriteLine(result);