
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1 7 -> такой позиции в массиве нет

Console.Clear();

Console.WriteLine("Введите размеры матрицы");

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];

for (int i = 0; i < m; i++)
   {
       for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
   }
Console.WriteLine();

Console.Write("Введите координаты a:");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты b:");
int b = Convert.ToInt32(Console.ReadLine());

// if (a>m || b>n) // || a < 0 || b<0 )
// Console.WriteLine("такого числа нет");
//      else
//          {
//              Console.WriteLine(matrix[a,b]);
//          }

if (a<=m && b<=n && a>=0 && b>=0)   
    Console.WriteLine(matrix[a,b]);
else Console.WriteLine("такого числа нет");