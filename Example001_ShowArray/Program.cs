// Показать двумерный массив размером m×n заполненный вещественными числами

int m = 5;
int n = 10;

int[,] matrix =new int[m, n];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
Console.WriteLine();    
}