// Задать двумерный массив следующим правилом: Aₘₙ = m+n

int m = 10;
int n = 10;
//int[,] A = new int [m,n]; 

int[,] matrix = new int[m,n];

PrintArray(matrix);
FillArray(matrix);
PrintArray(matrix);

void PrintArray(int[,] matr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
    Console.WriteLine();    
    }
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matr[i, j] = i+j; 
        }
    Console.WriteLine();    
    }
}

