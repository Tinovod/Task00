// //Напишите программу которая будет принимать на вход
//  число и проверять, кратно ли оно одновременно 7 и 23. 

// 14 -> нет
// 46 -> нет
// 161 -> да

// Используем функции из лекции

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

bool result = MultiplicityTwoDigit(number, 7, 23);
Console.WriteLine(result ? "Да" : "Нет");

bool MultiplicityTwoDigit(int numb, int numb1, int numb2)
{
    return (numb % numb1 == 0 && numb % numb2 == 0);
}