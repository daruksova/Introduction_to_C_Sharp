// Задача 60. ...Сформируйте трёхмерный массив двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,,] GenerateMatrix(int m, int n, int o)
{
    int[,,] matrix = new int[m, n, o];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < o; k++)
            {
                matrix[i, j, k] = rand.Next(0, 100);
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                System.Console.Write(matrix[i, j, k] + "(" + i + ", " + j + ", " + k + ")\t");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}

int a = ReadInt("Введите первую размерность матрицы: ");
int b = ReadInt("Введите вторую размерность матрицы: ");
int c = ReadInt("Введите третью размерность матрицы: ");
int[,,] matrix = GenerateMatrix(a, b, c);
PrintMatrix(matrix);

