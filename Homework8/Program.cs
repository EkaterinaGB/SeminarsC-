// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// int[,] RandomMatrix(int Line, int column)
// {
//     int[,] matrix = new int[Line, column];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 10);
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
//     return matrix;
// }

// int[,] Matrix(int[,] matrix)
// {
//     int min,
//         temp;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1) - 1; j++)
//         {
//             min = j;
//             for (int k = j; k < matrix.GetLength(1); k++)
//             {
//                 if (matrix[i, k] < matrix[i, min]) min = k;
//             }
//             temp = matrix[i, j];
//             matrix[i, j] = matrix[i, min];
//             matrix[i, min] = temp;
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             Console.Write($"{matrix[i, j]} ");
//         Console.WriteLine();
//     }
// }

// int[,] array = RandomMatrix(3, 5);
// PrintMatrix(Matrix(array));

// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// void MinSumRowMatrix(int[,] matrix)
// {
//     int sumRow = 0,
//         minSumRow = 0,
//         numMinSumRow = 0;
//     for (int j = 0; j < matrix.GetLength(1); j++)
//         minSumRow += matrix[0, j];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             sumRow += matrix[i, j];
//         if (sumRow < minSumRow)
//         {
//             minSumRow = sumRow;
//             numMinSumRow = i;
//         }
//         sumRow = 0;
//     }
//     Console.WriteLine($"Номер строки с наименьшей суммой элементов таблицы: {numMinSumRow + 1}");
// }

// int[,] array = CreateRandomMatrix(5, 2);
// MinSumRowMatrix(array);

// Задача 3: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2

// void Print(int[,,] matrix)
// {
//     for (int k = 0; k < matrix.GetLength(0); k++)
//     {
//         for (int i = 0; i < matrix.GetLength(1); i++)
//         {
//            for (int j = 0; j < matrix.GetLength(2); j++)
//            {
//                Console.Write($"{matrix[k,i, j]} {(k,i,j)} ");
//            }
//            Console.WriteLine();
//         }  
//     }
//     Console.WriteLine();
// }

// int[,,] array3 = new int[,,]
// {
//     {
//         {12,22},
//         {75,31}
//     },

//     {
//         {45,53},
//         {32,23}
//     }
// };
// Print(array3);

// Задача 4: Заполните спирально массив 4 на 4.

// void Print(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
// 	{
// 		for(int j = 0; j < array.GetLength(1); j++)
// 		{
//             Console.Write(array[i,j] + " ");
// 		}
//         Console.WriteLine("");
// 	}	
// }
// int[,] SpiralMatrix(int n)
// {
//    int[,] matrix = new int[n,n];
//    int start = 1, rows = n, columns = n, x = 0, y = 0;
//    while(x < rows)
//    {
//        for(int j = x; j < rows; j++)
//        {
//            matrix[y, j] = start;
//            start++;
//        }
//        rows = rows - 1;
//        for( int i = (y + 1); i < columns; i++)
//        {
//            matrix[i, columns-1] = start;
//            start++;
//        }
//        columns = columns - 1;
//        for(int j = (rows-1); j >= x; j=j-1)
//        {
//            matrix[rows, j] = start;
//            start++;
//        }
//        for(int i = (columns-1); i > y; i = i-1)
//        {
//            matrix[i, x] = start;
//            start++;
//        }
//        x++; y++;
//    }
//    return matrix;
// }
// Console.WriteLine("Введите размер квадратного массива n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Print(SpiralMatrix(n));


