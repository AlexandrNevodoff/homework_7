//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Clear();

// Console.WriteLine("Введите размеры матрицы");

// Console.Write("Введите m: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[m, n];

// for (int i = 0; i < m; i++)
//    {
//        for (int j = 0; j < n; j++)
//         {
//             matrix[i, j] = new Random().Next(0, 11);
//             Console.Write($"{matrix[i, j]} \t");
//         }
//         Console.WriteLine();
//    }    

// int summ = 0;
// int Summa (int[,] matrix)//, int row )
// {

// for ( int i = 0; i < m; i++)
    
//     summ = summ + matrix[i,0];
// return summ;
// //Console.WriteLine(result);

// }

// Summa(matrix);
// double result = summ/m;
// Console.Write($"Арифметическое столбца {m} - " + result); /// ТУТ Я ЗАСТРЯЛ :)
// --------------------------------------------


void InputMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}


void ReleaseMatrix(int[, ] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double summa = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            summa += matrix[i, j];
        }
        Console.WriteLine($"Столбец {j + 1} = {summa / matrix.GetLength(0)}");
    }
}


Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[, ] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
ReleaseMatrix(matrix);
