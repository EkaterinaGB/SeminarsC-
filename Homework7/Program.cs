// 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// void DoubleRandomArray(int m, int n)
// {
//     double[,] matrix = new double[m, n];

//     Console.WriteLine("Ваш массив: ");

//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             matrix [i, j] = Convert.ToDouble(new Random().Next(-1, 50) / 10.0);
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// Console.Write("Укажите количество строк: ");
// int lines = Convert.ToInt32(Console.ReadLine());
// Console.Write("Укажите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// double[,] userArray = new double[lines, columns];
// DoubleRandomArray(lines, columns);

// 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// void ValueArray(int m, int n) // 
// {
//     int[,] matrix = new int[3, 4];

//     int elementarray = 0;
//     for (int i = 0; i < 3; i++)
//     {
//         for (int j = 0; j < 4; j++)
//         {
//             matrix[i, j] = new Random().Next(10);
//             Console.Write($"{matrix[i, j]} ");
//             if (m == i || n == j)
//                 elementarray = matrix[m, n];
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine($"Указанный элемент имеет значение: {elementarray}.");
// }
// Console.Write("Укажите номер строки элемента таблицы: ");
// int rowindex = Convert.ToInt32(Console.ReadLine());
// Console.Write("Укажите номер столбца элемента таблицы: ");
// int columnindex = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[3, 4];
// if (rowindex < 3 && columnindex < 4)
//     ValueArray(rowindex, columnindex);
// else
//     Console.Write("Указанного Вами элемента в таблице нет.");

// 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// void ColumnAverage(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         double sum = 0;
//         for (int j = 0; j < array.GetLength(0); j++)
//         {
//             sum = sum + array[j, i];
//         }
//         sum = sum / array.GetLength(0);
//         sum = Math.Round(sum, 1);// получилось округлить так и вариант округления до сотых(

//         Console.WriteLine($"Среднее арифметическое столбца №{i + 1} таблицы равняется {sum}");
//     }
// }
// int[,] array = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
// ColumnAverage(array);


