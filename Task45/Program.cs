// Задача 45: Напишите программу, 
// которая будет создавать копию
// заданного массива с помощью 
// поэлементного копирования.


int[] Array(int num)
{
    int[] array = new int[num];
    // array[0] = 0;
        for (int i = 0; i < num; i++)
    {
        array[i] = array[i - 1] + array[i - 2];

    }
    return array;

}
void CopyArray(int[] arr)
 {
    int[] newarr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        newarr[i] = arr[i];
    }
    return newarr;
 }

void PrintArray(int[] arr)
 {
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
 }

Console.WriteLine("Введите число > 2: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] FiboArray = fiboArray(number);
PrintArray(FiboArray);
int[] array = CopyArray(5,1,9);
PrintArray(CopyArray);
