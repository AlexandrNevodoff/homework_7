//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
            matrix[i, j] = new Random().Next(0, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
   }    

int summ = 0;
int Summa (int[,] matrix)//, int row )
{

for ( int i = 0; i < m; i++)
    
    summ = summ + matrix[i,0];
return summ;
//Console.WriteLine(result);

}

Summa(matrix);
double result = summ/m;
Console.Write($"Арифметическое столбца {m} - " + result);
