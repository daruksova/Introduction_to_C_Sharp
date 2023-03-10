// Составить частотный словарь элементов двумерного массива. Частотный
// словарь содержит информацию о том, сколько раз встречается элемент
// входных данных.

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

void Dictionary(int[,] matrix)
{
    for (int k = 0; k < 10; k++)
    {
        int count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == k)
                {
                    count += 1;
                }
            }
        }
        if (count != 0)
        {
            if (count == 2 || count == 3 || count == 4)
            {
                System.Console.WriteLine($"{k} встречается {count} раза");
            }
            else if (count != 0)
            {
                System.Console.WriteLine($"{k} встречается {count} раз");
            }
        }
    }
}

int rows = ReadInt("Введите количество строк массива: ");
int cols = ReadInt("Введите количество столбцов массива: ");
int[,] matrix = GenerateMatrix(rows, cols);
PrintMatrix(matrix);
Dictionary(matrix);
