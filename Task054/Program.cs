// Задайте двухмерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

int[,] CreateMatrix(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    for (int row = 0; row < m; row++)
    {
        for (int colum = 0; colum < n; colum++)
        {
            matrix[row, colum] = new Random().Next(min, max+1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int colum = 0; colum < matrix.GetLength(1); colum++)
        {
            System.Console.Write($"{matrix[row, colum]}\t");
        }
        Console.WriteLine();
    }
}

int[,] SortDescendingOrder(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
              if (matrix[i, k] < matrix[i, k + 1]) // если нужно упорядочить по возрастанию, то меняется знак
              {
                int temp = 0;
                temp = matrix[i, k + 1];
                matrix[i, k + 1] = matrix[i, k];
                matrix[i, k] = temp;
              }  
            }
        }
    }
    return matrix;
}

int[,] matrix = CreateMatrix(3, 5, -10, 10);
PrintMatrix(matrix);
System.Console.WriteLine();
SortDescendingOrder(matrix);
PrintMatrix(matrix);