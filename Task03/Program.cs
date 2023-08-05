// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите номер");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 == 1) 
{
    Console.WriteLine("День недели Понедельник");
}
if (number1 == 2)
{
    Console.WriteLine("День недели Вторник");
}
if (number1 == 3)
{
    Console.WriteLine("День недели Среда");
}
if (number1 == 4)
{
    Console.WriteLine("День недели Четверг");
}
if (number1 == 5)
{
    Console.WriteLine("День недели Пятница");
}
if (number1 == 6)
{
    Console.WriteLine("День недели Суббота");
}
if (number1 == 7)
{
    Console.WriteLine("День недели Воскресенье");
}
if (number1 > 7)
{
    Console.WriteLine("Введите корректное число от 1 до 7");
}