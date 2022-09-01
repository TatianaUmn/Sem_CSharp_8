// Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.

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

void ResultMatrix(int[,] matrixFirst, int[,] matrixSecond, int[,] resultmatrix)
{
    for (int i = 0; i < matrixFirst.GetLength(0); i++)
    {
        for (int j = 0; j < matrixSecond.GetLength(1); j++)
        {
            for (int k = 0; k < matrixFirst.GetLength(1); k++)
            {
                resultmatrix[i, j] += matrixFirst[i, k] * matrixSecond[k, j];
            }
        }
    }
}

int[,] matrixFirst = CreateMatrix(3, 2, 0, 10); // число столбцов матрицы1 должно быть равно числу строк матрицы2
PrintMatrix(matrixFirst);
System.Console.WriteLine();
int[,] matrixSecond = CreateMatrix(2, 4, 0, 10);
PrintMatrix(matrixSecond);
System.Console.WriteLine();
int[,] resultmatrix = new int[3, 4]; // число строк этой матрицы равны числу строк матрицы1, число столбцов -числу столбцов матрицы2
ResultMatrix(matrixFirst, matrixSecond, resultmatrix);
Console.Write("Рeзультирующая матрица: ");
System.Console.WriteLine();
PrintMatrix(resultmatrix);
