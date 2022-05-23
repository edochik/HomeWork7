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

void Remove(int[,] array, int row, int column) // должен удалять строчку и столбец
{
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];// создаем новый массив меньше на 1 строчку и 1 колонку
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            newArray[i, j] = array[i, j];
        }
    }
    for (int i = row + 1; i < array.GetLength(0); i++)
    {
        for (int j = column + 1; j < array.GetLength(1); j++)
        {
            newArray[i - 1, j - 1] = array[i, j];
        }
    }
    array = newArray;
}

int[,] array = new int[4, 4];
NewMatrix(array);
PrintMatrix(array);
Console.WriteLine(FindSmallIndex(array));
Console.WriteLine();
Remove(array, 3, 3);
PrintMatrix(array);

/*
Вячеслав, добрый вечер. Спасибо за обратную связь. 
1. ДЗ по спирали, пытался сделать сам, но все равно не до конца понимаю. Но смог сделал благодаря уроку на youtube.
2. ДЗ 
*/