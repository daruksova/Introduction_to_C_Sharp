// Задайте двумерный массив из целых чисел. Напишите программу, которая
// удалит строку и столбец, на пересечении которых расположен
// наименьший элемент массива.

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rand.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[] FindMinElement(int[,] matrix)
{
    int minElement = matrix[0, 0];
    int[] minElementPosition = new int[2];
    minElementPosition[0] = 0;
    minElementPosition[1] = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < minElement)
            {
                minElement = matrix[i, j];
                minElementPosition[0] = i;
                minElementPosition[1] = j;
            }
        }
    }
    return minElementPosition;
}

int[,] CreateNewMatrix(int[,] matrix, int row, int col)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1,matrix.GetLength(1) - 1];
    for (int i = 0; i < newMatrix.GetLongLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLongLength(1); j++)
        {
            if (i >= row && j >= col)
            {
                newMatrix[i, j] = matrix[i + 1, j + 1];
            }
            else if (i >= row)
            {
                newMatrix[i, j] = matrix[i + 1, j];
            }
            else if (j >= col)
            {
                newMatrix[i, j] = matrix[i, j + 1];
            }
            else
            {
                newMatrix[i, j] = matrix[i, j];
            }
        }
    }
    return newMatrix;
}

int rows = ReadInt("Введите количество строк массива: ");
int cols = ReadInt("Введите количество столбцов массива: ");
int[,] matrix = GenerateMatrix(rows, cols);
PrintMatrix(matrix);
int[] minElementPosition = FindMinElement(matrix);
System.Console.WriteLine($"Индекс минимального элемента [{minElementPosition[0]}, {minElementPosition[1]}]");
PrintMatrix(CreateNewMatrix(matrix, minElementPosition[0], minElementPosition[1]));
