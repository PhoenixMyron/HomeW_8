// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
void RandomMatrix(int[, ] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1, 10); // [1, 10];
    }
}
}
void RandomSecondMatrix(int[, ] SecondMatrix)
{
for (int i = 0; i < SecondMatrix.GetLength(0); i++)
{
    for (int j = 0; j < SecondMatrix.GetLength(1); j++)
    {
        SecondMatrix[i, j] = new Random().Next(1, 10); // [1, 10];
    }
}
}

void PrintMatrix(int[,] matr)
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
void PrintSecondMatrix(int[,] SecondMatrix)
{
    for (int i = 0; i < SecondMatrix.GetLength(0); i++) 
{
    for (int j = 0; j < SecondMatrix.GetLength(1); j++) 
    {
        Console.Write($"{SecondMatrix[i, j]} \t");
    }
  Console.WriteLine();
}
}
void PrintResultMatrix(int[,] ResultMatrix)
{
    for (int i = 0; i < ResultMatrix.GetLength(0); i++) 
{
    for (int j = 0; j < ResultMatrix.GetLength(1); j++) 
    {
        Console.Write($"{ResultMatrix[i, j]} \t");
    }
  Console.WriteLine();
}
}
void SummOfMatrix(int[, ] matrix,int[, ] SecondMatrix,int[, ] ResultMatrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        int temp = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            temp = matrix[i,j] * SecondMatrix[i,j];
            ResultMatrix[i,j] = temp;
        }
    }

}
Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[, ] matrix = new int[size[0], size[1]];
int[, ] SecondMatrix = new int[size[0], size[1]];
int[, ] ResultMatrix = new int[size[0], size[1]];
RandomMatrix(matrix);
RandomSecondMatrix(SecondMatrix);
PrintMatrix(matrix);
Console.WriteLine();
PrintSecondMatrix(SecondMatrix);
Console.WriteLine();
SummOfMatrix(matrix,SecondMatrix,ResultMatrix);
PrintResultMatrix(ResultMatrix);

