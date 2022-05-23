
/*
3. Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы 
соответствующего элемента
*/
//1. Создать трехмерный массив.
//2. Сделать неповторяющиеся значения в массиве. 
int[,,] NewMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                matrix[i, j, z] = new Random().Next(10, 100);
            }

        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.WriteLine("page №: " + (i + 1));
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                Console.Write($" {matrix[i, j, z]}");
            }
            Console.WriteLine();
        }
        Console.WriteLine("=====================");
    }
}

Random rnd = new Random();
int[] a = new int[100];
a[0] = rnd.Next(0, 101);
for (int i = 1; i < 100;)
{
    int num = rnd.Next(0, 101); // генерируем элемент
    int j;
    // поиск совпадения среди заполненных элементов
    for (j = 0; j < i; j++)
    {
        if (num == a[j])
            break; // совпадение найдено, элемент не подходит
    }
    if (j == i)
    { // совпадение не найдено
        a[i] = num; // сохраняем элемент
        i++; // переходим к следующему элементу
    }
}
for (int i = 0; i < 100; i++)
{
    Console.Write("{0,4} ", a[i]);
    if (i % 10 == 9)
        Console.WriteLine();
}


int[,,] matrix = new int[3, 3, 3];
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


