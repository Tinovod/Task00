// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.
// i = 3, j = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] CreateMatrixSumInd(int rows, int colums)
{
    int[,] matrix = new int[rows, colums];//rows=3
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            matrix[i, j] = i + j;
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
int[,] arraySumInd = CreateMatrixSumInd(3, 4);
PrintMatrix(arraySumInd);