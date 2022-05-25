/*
1. Спирально заполнить двумерный массив:
  1  2  3  4
 12 13 14  5
 11 16 15  6
 10  9  8  7 
*/


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($" {matrix[i, j]}");
        }
        Console.WriteLine();
    }
}
void SpiralMatrix(int[,] matrix)
{
    int n = matrix.GetLength(0);
    int number = 1;//заводим переменную, чтобы заполнять от 1.2.3.4.n.
    for (int i = 0; i < n / 2; i++)
    {
        for (int j = i; j < n - i; j++)//заполняется первая строка
        {
            matrix[i, j] = number++;
        }
        for (int j = i + 1; j < n - i; j++) //заполняется правый столбец
        {
            matrix[j, n - 1 - i] = number++;
        }
        for (int j = n - i - 2; j > i; j--) //заполняется последняя строка
        {
            matrix[n - 1 - i, j] = number++;
        }
        for (int j = n - 1 - i; j > i; j--)// заполняется левый столбец
        {
            matrix[j, i] = number++;
        }

    }

}

int[,] NewMatrix = new int[6, 6];
Console.WriteLine();
SpiralMatrix(NewMatrix);
PrintMatrix(NewMatrix);
//для решения данной задачи использовал данный урок https://www.youtube.com/watch?v=I58renaSzq4

