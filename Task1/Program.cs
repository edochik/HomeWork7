

/*
1. Спирально заполнить двумерный массив:
  1  2  3  4
 12 13 14  5
 11 16 15  6
 10  9  8  7 
*/
//1. Как печатать массив по порядку? (нашел)
//2. Как сделать так, чтобы доходили до конца и шли в низ?
/*

int[,] CreateMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = (i * matrix.GetLength(1)) + j + 1;//печатаем массив с начала и далее прибавляем по 1 единице
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
            Console.Write($" {matrix[i, j]}");
        }
        Console.WriteLine();
    }
}

int TurnMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j]
        }
    }
}
int[,] NewMatrix = new int[4, 4];
CreateMatrix(NewMatrix);
PrintMatrix(NewMatrix);
*/

/*
namespace ConsoleApplication1
{
    internal class NewBaseType
    {
        static void Main()
        {
            int n;
            Console.WriteLine("Введите размерность массива");
            n = 10;
            var a = GetSpire(n);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }
        }
    }

    class Program : NewBaseType
    {
        private static int[,] GetSpire(int n)
        {
            var result = new int[n, n];
  
            for (int currentChar = 1, padding = 0; padding < n / 2; padding++)
            {
                for (int j = padding; j < n - padding; j++)
                {
                    result[padding, j] = currentChar;
                }
                for (int j = padding; j < n - padding; j++)
                {
                    result[n - padding - 1, j] = currentChar;
                }
                for (int i = padding + 2; i < n - padding - 1; i++)
                {
                    result[i, padding] = currentChar;
                }
                for (int i = padding + 1; i < n - padding - 1; i++)
                {
                    result[i, n - padding - 1] = currentChar;
                }
                currentChar = 1 - currentChar;
                result[padding + 1, padding] = currentChar;
            }
            if (n % 2 != 0 && result[0, 0] == 1)
                result[n / 2, n / 2] = 1;
            return result;
        }
    }
}
*/
/*