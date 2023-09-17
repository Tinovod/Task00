// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

int[,] CreateMatrixSumInd(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];//rows=3
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;

}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            Console.Write($"{matrix[i, j],6}"); // 6 это какой отступ между элементами массива
        }
        Console.WriteLine("|");
        // Console.WriteLine();
    }

}

void SearchEvenIndexRaplaceQuart(int[,] matrix)

    {
            for (int i = 0; i < matrix.GetLength(0); i+=2)
        {
            for (int j = 0; j < matrix.GetLength(0); j+=2)
            {
                matrix[i, j] *= matrix[i, j];
                // if (i % 2 == 0 && j % 2 == 0) matrix[i, j] *= matrix[i, j];
            }

        }
        
    }




    int[,] array2d = CreateMatrixSumInd(3, 4, 1, 9);
    PrintMatrix(array2d);
    Console.WriteLine();
    SearchEvenIndexRaplaceQuart(array2d);
    PrintMatrix(array2d);