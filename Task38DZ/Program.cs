// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArrayRndInt(int size, double min, double max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]:F1}, ");
        else Console.Write($"{arr[i]:F1}");
    }
    Console.Write("]");
}

double FindDiff(double[] arr)
{
    
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];

    }
    double diff = max - min;
    return diff;
}

double Maximum(double[] arr)
{
    
    double min = arr[0];
    double max = arr[0];
    double res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];

    }
      res += max;
      return res;
}
double Minimum(double[] arr)
{
    
    double min = arr[0];
    double max = arr[0];
    double res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];

    }
      res += min;
      return res;
}

double[] doubleChislo = CreateArrayRndInt(5, 1, 89);
PrintArray(doubleChislo);
double findDiff = FindDiff(doubleChislo);
double maximum = Maximum(doubleChislo);
double minimum = Minimum(doubleChislo);
Console.WriteLine($" => {maximum:F1} - {minimum:F1} = {findDiff:F1}");
