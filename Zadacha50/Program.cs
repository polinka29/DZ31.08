// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void PrintArray(int[,]myarray)
{
    for (int i = 0; i < myarray.GetLength(0); i++)
    {
        for (int j = 0; j < myarray.GetLength(1); j++)
        {
            myarray[i, j] = new Random().Next(1,10);
            Console.Write($" {myarray[i, j]}");
        }
        Console.WriteLine();
    }
}
void Main(int[,] myarray, int start)
{
    int count = 0;
    for (int i = 0; i < myarray.GetLength(0); i++)
    {
        for (int j = 0; j < myarray.GetLength(1); j++)
        {
            if (myarray[i, j] == start) 
            Console.WriteLine($"число {start} находится на ({i}, {j}) позиции");
            count++;
        }
    }
if (count !=0) 
Console.WriteLine($"числа {start} нет в массиве");
}
int m = new Random().Next(1,5);
int n = new Random().Next(1,5);
int [,] array = new int[m, n];
PrintArray(array);
Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
Main(array, A);