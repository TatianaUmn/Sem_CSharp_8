// Задайте прямоугольный двухмерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

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

int RowMinSum(int[,] matrix)
{
    int sum = 0;
    int minSum = 0;
    int minNumber = 0;
    for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
            if (m == 0)
            {
                sum += matrix[m, n];
                minSum += matrix[m, n];
            }
            else sum += matrix[m, n];
        }
        if (sum < minSum)
        {
            minSum = sum;
            minNumber = m;
        }
        sum = 0;
    }
    return minNumber;
}

int[,] matrix = CreateMatrix(3, 4, 0, 10);
PrintMatrix(matrix);
System.Console.WriteLine();
Console.WriteLine("Cтрока с наименьшей суммой элементов: " + RowMinSum(matrix));