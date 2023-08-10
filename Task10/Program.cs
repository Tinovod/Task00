// //Напишите программу которая 
// 1/выводит случайное трехзначное число и на выходе показывает вторую 
// цифру этого числа
// 456-> 5
// 782->8
// 918->1

// Используем функции из лекции

int number = new Random().Next(100, 1000); //получим рандомные числа от 10 до 100
Console.WriteLine($"Случайное число из диапозона от 100 до 999 --> {number}");

int digit = Digit(number);
Console.WriteLine(digit);

int Digit(int num) // num = number название метода
//  и параметр, или исходные данные
{
    int secondDigit = (num / 10) % 10;
    int result = (secondDigit);
    return result;
}