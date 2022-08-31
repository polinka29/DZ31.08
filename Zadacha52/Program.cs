// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int m = new Random().Next(1, 5);
int n = new Random().Next(1, 5);
int[,] myarray = new int[m, n];
for (int i = 0; i < myarray.GetLength(0); i++)
{
    for (int j = 0; j < myarray.GetLength(1); j++)
    {
        myarray[i, j] = new Random().Next(1, 10);
        Console.Write($"{myarray[i , j]} ");
    }
    Console.WriteLine();
}
for (int j = 0; j < myarray.GetLength(1); j++)
{
   double sum = 0;
   for (int i = 0; i < myarray.GetLength(0); i++)
   {
     sum = sum + myarray[i, j];
   }
   Console.WriteLine($"среднее арифмитическое столбца:{Math.Round(sum/m, 2)}; ");
}
