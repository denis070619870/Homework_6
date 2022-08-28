// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)                         //Цикл обработки строк
    {
        for (int j = 0; j < matr.GetLength(1); j++)                     //Цикл обработки столбцов
        {
            Console.Write($"{matr[i, j]} ");   
        }
    Console.WriteLine();    
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); 
        }
    Console.WriteLine();    
    }
}

void SquareEvenIndex(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i != 0 && i % 2 == 0 && j % 2 == 0)   
            {
                matr[i, j] = matr[i,j] * matr[i,j]; 
            }
        }
    Console.WriteLine();    
    }
}

int[,] matrix = new int[5, 5];

FillArray(matrix);
PrintArray(matrix);
SquareEvenIndex(matrix);
Console.WriteLine(); 
PrintArray(matrix);

