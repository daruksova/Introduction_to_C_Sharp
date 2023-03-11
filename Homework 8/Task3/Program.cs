// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return resultMatrix;
}

int rows1 = ReadInt("Введите количество строк первой матрицы: ");
int cols1 = ReadInt("Введите количество столбцов первой матрицы: ");
int[,] matrix1 = GenerateMatrix(rows1, cols1);
PrintMatrix(matrix1);
int rows2 = ReadInt("Введите количество строк второй матрицы: ");
int cols2 = ReadInt("Введите количество столбцов второй матрицы: ");
int[,] matrix2 = GenerateMatrix(rows2, cols2);
PrintMatrix(matrix2);
System.Console.WriteLine();

if (matrix1.GetLength(1) == matrix2.GetLength(0))
{
    PrintMatrix(MultiplyMatrix(matrix1, matrix2));
}
else
{
    System.Console.WriteLine("Данные матрицы нельзя умножить");
}

