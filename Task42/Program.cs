// Задача 42: Напишите программу, 
// которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int DecimalToBin (int num)
{
    int res = 0;
    int factor = 1;
    while(num > 0)  
    {
    res += num % 2 * factor;
    num /= 2;
    factor *= 10;
    }
    return res;
 }



Console.WriteLine ("Введите число:");
int num1 = Convert.ToInt32(Console.ReadLine());

int decimalToBin = DecimalToBin(num1);
Console.WriteLine(decimalToBin);