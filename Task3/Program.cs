
3. Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы 
соответствующего элемента
*/

int[,,] NewMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                matrix[i, j, z] = new Random().Next(0, 9);
            }

        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                Console.Write($" {matrix[i, j, z]}");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] matrix = new int[5, 5, 5];
NewMatrix(matrix);
PrintMatrix(matrix);




//https://www.youtube.com/watch?v=NLu9y4LKXQ0


/*
//задача из интернета распечатать определенный узор в двухмерном массиве
int[,] CreateMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j) matrix[i, j] = 1;
            else if (i == (matrix.GetLength(1) - 1) - j) matrix[i, j] = 1;
            else matrix[i, j] = 0;
        }
    }
    return matrix;
}



int[,] matrix = new int[7, 7];


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

PrintMatrix(CreateMatrix(matrix));
*/


