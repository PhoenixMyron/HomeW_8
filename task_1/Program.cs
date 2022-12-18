﻿// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
void InputMatrix(int[, ] matrix)
{
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
void ChangeRows(int[, ] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 1; j < matrix.GetLength(1); j++)
{
    int k = j;
    while ( k > 0 && matrix[i, k - 1] < matrix[i,k])
    {
        int temp = matrix[i, k - 1];
        matrix[i, k - 1] = matrix[i,k];
        matrix[i,k] = temp;
        k -= 1;
    }
}
}
Console.WriteLine();
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
Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[, ] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
ChangeRows(matrix);
PrintArray(matrix);