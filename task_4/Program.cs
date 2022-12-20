// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
// bool checkElement(int[] array, int number)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == number)
//             return false;
//     }
//     return true;
// } 
void RandomArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
  int x = new Random().Next(10, 100);
  while (array.Contains(x))
  {
    x = new Random().Next(10, 100);

  }
  array[i] = x;
}
}
void RandomMatrix(int[, , ] matrix, int[] array)
{
    int count = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = 0; k < matrix.GetLength(2); k++)
        {
           matrix[i,j,k] = array[count];
           count++;
        }
    }
}
}

void PrintMatrix(int[, , ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) 
{
    for (int j = 0; j < matrix.GetLength(1); j++) 
    {
       for (int k = 0; k < matrix.GetLength(2); k++)
       {
        Console.Write($"{matrix[i, j, k]}  ({i},{j},{k}) \t");

       }
       Console.WriteLine();
    }
}
}
Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[, , ] matrix = new int[size[0], size[1], size[2]];
int[] array = new int[size[0] * size[1] * size[2]];
RandomArray(array);
RandomMatrix(matrix,array);
PrintMatrix(matrix);