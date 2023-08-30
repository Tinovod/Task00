// Задача 19: Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом. 
// 14212 -> нет
// 23432 -> да
// 12821 -> да

int Palindrom(int num)
 
  {
        if (num <= 99999)
       {
        int firstDigit = (num / 10000);
        int secondDigit = (num / 1000) % 10;
        int fourthDigit = (num / 10) % 10;
        int fifthDigit = (num % 10);
        
            if (firstDigit == fifthDigit && secondDigit == fourthDigit)
            {
                Console.WriteLine ($" Число {num} является палиндромом");
            }
       
       else 
       {
        Console.WriteLine($" Число {num} не является палиндромом");
       }
       }
        return num;
 }


Console.WriteLine("Введите пятизначное число : ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99999)
Console.WriteLine("Введите пятизначное число");
 
 int palindrom = Palindrom(number);

// int Division(int num)
//  {
//         int firstDigit = (num / 10000);
//         int secondDigit = (num / 1000) % 10;
//         int fourthDigit = (num / 10) % 10;
//         int fifthDigit = (num % 10);
//        if (firstDigit == fifthDigit && secondDigit == fourthDigit)
//         Console.WriteLine ("Число является палиндромом");
//         else 
//        {
//            Console.WriteLine("Число не является палиндромом");
//        }

//      return num;
//  }


// Console.WriteLine("Введите пятизначное число : ");
// int number = Convert.ToInt32(Console.ReadLine());
 
//  int division = Division(number);