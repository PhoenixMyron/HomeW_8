// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// void PrintMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++) 
// {
//     for (int j = 0; j < matr.GetLength(1); j++) 
//     {
//         Console.Write($"{matr[i, j]} \t");
//     }
//   Console.WriteLine();
// }
// }
// Console.Clear();
// Console.Write("Введите размеры матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[, ] matrix = new int[size[0], size[1]];

// PrintMatrix(matrix);
Console.Clear();
Console.Write("Enter matrix size n and m via space: ");
string[] numbers = Console.ReadLine().Split(" ");
int[,] matrix = new int[int.Parse(numbers[0]), int.Parse(numbers[1])];
int n = matrix.GetLength(0);
int m = matrix.GetLength(1);
int iBeginnig = 0, iFinal = 0, jBeginnig = 0, jFinal = 0;
int k = 1;
int i = 0;
int j = 0;
while (k <= n * m)
    {
        matrix[i,j] = k;
        if (i == iBeginnig && j < m - jFinal - 1)
            ++j; // move to the right
        else if (j == m - jFinal - 1 && i < n - iFinal - 1)
            ++i; // go down
        else if (i == n - iFinal - 1 && j > jBeginnig)
            --j; // move to the left
        else
            --i; // go up

        if ((i == iBeginnig + 1) && (j == jBeginnig) && (jBeginnig != m - jFinal - 1)){
            ++iBeginnig;
            ++iFinal;
            ++jBeginnig;
            ++jFinal;
        }
        ++k;
    }
    
    for ( i = 0; i < matrix.GetLength(0); ++i)
    {
        for (j = 0; j < matrix.GetLength(1); ++j)
        Console.Write($"{matrix[i,j]} \t"  );
        Console.Write("\n");
    }

return 0;