// //Напишите программу которая 
// 1/выводит случайное трехзначное число из отрезка
// 2/ удаляет вторую цифру этого числа
// 456-> 46
// 782->72
// 918->98

// Используем функции из лекции

int number = new Random().Next(100, 1000); //получим рандомные числа от 10 до 100
Console.WriteLine($"Случайное число из диапозона от 100 до 999 --> {number}");

// int firstDigit = number / 100;
// int lastDigit = number % 10;

// int result = firstDigit * 10 + lastDigit;
// Console.WriteLine(result);

// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа {secondDigit}");

// int Digit = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшая цифра числа {maxDigit}");

int digit = Digit(number);
Console.WriteLine(digit);

int Digit(int num) // num = number название метода
//  и параметр, или исходные данные
{
     int firstDigit = num / 100; //делим на 10 получаем 7,8 т.к. int используется поэтому выводится только 7, а это первое число
     int lastDigit = num % 10; // остаток от деление это третье число
     // if (firstDigit > secondDigit) return firstDigit;
     // else return 0;
     int result = firstDigit * 10 + lastDigit;
     return result;
}