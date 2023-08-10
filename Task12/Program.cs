// //Напишите программу которая будет принимать на вход
// 2 числа и выводить, 
// является ли первое число кратное второму 
// если первое число не кратно второму, то программа
// выводит остаток от деления.
// 34, 5-> 4
// 16, 4 -> кратно

// Используем функции из лекции

Console.WriteLine("Введите два числа число");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

int remainder = Remainder(number1, number2);

if (remainder == 0)
{
    Console.WriteLine($"Число {number1} кратно числу {number2}");
}
else Console.WriteLine($"Число {number1} не кратно числу {number2}. Остаток от деления {remainder}");

int Remainder(int numb1, int numb2)
{
    int remainder = number1 % number2;
    return numb1 % numb2;
}