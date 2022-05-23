/*
2. В двумерном массиве целых чисел. 
Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
*/

int[,] NewMatrix(int[,] matrix)//создать массив
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 99);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)// печать массива
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


int[,] Remove(int[,] array) // должен удалять строчку и столбец
{
    int min = array[0, 0];
    int row = 0;
    int column = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (min > array[i, j])
            {
                min = array[i, j];
                row = i;
                column = j;
            }
        }
    }

    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];// создаем новый массив меньше на 1 строчку и 1 колонку

    for (int i = 0, j = 0; i < array.GetLength(0); i++)
    {
        if (i == row)
            continue;

        for (int k = 0, u = 0; k < array.GetLength(1); k++)
        {
            if (k == column)
                continue;

            newArray[j, u] = array[i, k];
            u++;
        }
        j++;
    }

    return newArray;
}
int[,] array = new int[4, 4];
NewMatrix(array)
PrintMatrix(array);
Console.WriteLine();
var trim = Remove(array);

PrintMatrix(trim);







// нахождение минимального элемента и вывод двух значений
/*
(int, int) FindSmallIndex(int[,] array)//находит наименьший элемент в массиве
{
    int min = array[0, 0];
    int row = 0;
    int column = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (min > array[i, j])
            {
                min = array[i, j];
                row = i;
                column = j;
            }
        }
    }
    return (row, column);
}
*/