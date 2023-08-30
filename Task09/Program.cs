// //Напишите программу которая 
// 1/выводит случайное число из отрезка [10,99]
// 2/ показывает наибольшую цифру числа
// 78-> 8
// 12->2
// 85->8

// Используем функции из лекции

int number = new Random().Next(10, 100); //получим рандомные числа от 10 до 100
Console.WriteLine($"Случайное число из диапозона от 10 до 99 --> {number}");

// int firstDigit = number / 10; //делим на 10 получаем 7,8 т.к. int используется поэтому выводится только 7, а это первое число
// int secondDigit = number % 10;

// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа {secondDigit}");

// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшая цифра числа {maxDigit}");
int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа {maxDigit}");

int MaxDigit(int num) // num = number
{
    int firstDigit = num / 10; //делим на 10 получаем 7,8 т.к. int используется поэтому выводится только 7, а это первое число
    int secondDigit = num % 10;
    // if (firstDigit > secondDigit) return firstDigit;
    // else return 0;
    int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    return result;
}