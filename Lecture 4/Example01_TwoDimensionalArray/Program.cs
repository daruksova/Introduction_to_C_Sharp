// Двумерный массив строк

// string[,] table = new string[2, 5];
// table[1, 2] = "слово";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         System.Console.WriteLine($"-{table[rows, columns]}- ");
//     }
// }

// Двумерный массив чисел

int[,] matrix = new int[3, 4];

for (int rows = 0; rows < matrix.GetLength(0); rows++)
{
    for (int columns = 0; columns < matrix.GetLength(1); columns++)
    {
        System.Console.Write($"{matrix[rows, columns]} ");
    }
    System.Console.WriteLine();
}
