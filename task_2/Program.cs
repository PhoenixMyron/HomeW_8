// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

// void InputMatrix(int[, ] matrix)
// {
//     if (matrix.GetLength(0) == matrix.GetLength(1) )
//     {
//         Console.Write("Размеры матрицы не должны быть одинаковыми. \nВведите размеры матрицы: ");
//         int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
//         matrix = new int[size[0], size[1]];
//     }
// for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = new Random().Next(1, 10); // [1, 10]
//         Console.Write($"{matrix[i, j]} \t");
//     }
//     Console.WriteLine();
//     }
// }

// void PrintArray(int[,] matr)
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


// void ChangeRows(int[, ] matrix)
// {
//     int sum = int.MaxValue;
//     int index = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)  
//     {
//         int temp = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++) 
//         {
//             temp += matrix[i, j];
//         }
//         if (temp < sum)
//         {
//             sum = temp;
//             index = i;
//         }
//     }
// Console.WriteLine("Строка: " + ++index );
// }

// Console.Clear();
// Console.Write("Введите размеры матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[, ] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// ChangeRows(matrix);

void InputMatrix(int[, ] matrix)
{
    if (matrix.GetLength(0) == matrix.GetLength(1) )
    {
        Console.Write("Размеры матрицы не должны быть одинаковыми. \nВведите размеры матрицы: ");
        int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
        matrix = new int[size[0], size[1]];
    }
for (int i = 0; i < matrix.GetLength(0); i++)
    {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1, 10); // [1, 10]
        Console.Write($"{matrix[i, j]} \t");
    }
    Console.WriteLine();
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) 
{
    for (int j = 0; j < matr.GetLength(1); j++) 
    {
        Console.Write($"{matr[i, j]} \t");
    }
  Console.WriteLine();
}
}


void ChangeRows(int[, ] matrix)
{
    int sum = int.MaxValue;
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)  
    {
        int temp = 0;
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            temp += matrix[i, j];
        }
        if (temp < sum)
        {
            sum = temp;
            index = i;
        }
    }
Console.WriteLine("Строка с наименьшой суммой элементов: " + ++index );
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[, ] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
ChangeRows(matrix);
