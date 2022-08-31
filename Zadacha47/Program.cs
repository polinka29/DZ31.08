// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
int m = new Random().Next(2, 6);
int n = new Random().Next(2, 6);
double [,] arr = new double [m, n];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
    arr[i, j] = new Random().Next(1,10)+ Math.Round(new Random().NextDouble(),1);
    Console.Write($"{arr[i, j]} ");
    }
Console.WriteLine();
}
