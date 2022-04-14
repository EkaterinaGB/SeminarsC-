// 1. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

// void NewRandomArray(int m, int n)
// {
//     int[,] matrix = new int[m, n];

//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             matrix[i, j] = new Random().Next(-99, 100);
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// NewRandomArray(2, 6);
// // 2. Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.

// void FindElementInArray(int m, int n)
// {
//     int[,] matrix = new int[m, n];

//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             matrix[i, j] = i + j;
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// FindElementInArray(2, 6);

// 3. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// void FindBothPositiveElement(int m, int n)
// {
//     int[,] matrix = new int[m, n];

//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             matrix[i, j] = new Random().Next(0, 10);

//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 matrix[i, j] = matrix[i, j] * matrix[i, j];
//             }
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// FindBothPositiveElement(3, 3);

// 4. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

// void SumOfElementOnMainDiagonal(int m)
// {
//     int sum = 0;
//     int[,] matrix = new int[m, m];

//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < m; j++)
//         {
//             matrix[i, j] = new Random().Next(0, 10);
//             if (i == j)
//             {
//                 sum = sum + matrix[i, j];
//             }
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine("Сумма элементов по диагонали равна: " + sum);
// }
// SumOfElementOnMainDiagonal(3);