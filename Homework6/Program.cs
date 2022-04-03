
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// void Num(int M)
// {
//     int result = 0;
//     for (int i = 1; i < M; i++)
//     {
//         Console.Write($"Введите {i} число: ");
//         int n = Convert.ToInt32(Console.ReadLine());
//         if (n > 0) result++;
//     }
//     Console.WriteLine($"Число введенных Вами натуральных чисел: {result}.");
// }

// Console.Write("Укажите сколько чисел Вы хотите ввести: ");
// int value = Convert.ToInt32(Console.ReadLine());
// Num(value);

// void Array(int[,] massiv)
// {
//     for (int i = 0; i < massiv.GetLength(0); i++)
//     {
//         for (int j = 0; j < massiv.GetLength(1); j++)
//         {
//             if (i == 0 || i == massiv.GetLength(0) - 1 || j == 0 || j == massiv.GetLength(1) - 1) massiv[i, j] = 1;
//             else massiv[i, j] = 0;
//             Console.Write($"{massiv[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Укажите количество строк: ");
// int lines = Convert.ToInt32(Console.ReadLine());
// Console.Write("Укажите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] printArray = new int[lines, columns];
// Array(printArray);












