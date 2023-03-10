// Задайте двумерный массив. Напишите программу, которая заменяет строки
// на столбцы. В случае, если это невозможно, программа должна вывести
// сообщение для пользователя.

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

int[,] TurnMatrix(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            newMatrix[j, i]= matrix[i, j];
        }
    }
    return newMatrix;
}

int rows = ReadInt("Введите количество строк массива: ");
int cols = ReadInt("Введите количество столбцов массива: ");
int[,] matrix = GenerateMatrix(rows, cols);
PrintMatrix(matrix);
System.Console.WriteLine();
PrintMatrix(TurnMatrix(matrix));