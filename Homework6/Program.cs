
// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

void Num(int M)
{
    int result = 0;
    for (int i = 0; i < M; i++)
    {
        Console.Write($"Введите {i} число: ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n > 0) result++;
    }
    Console.WriteLine($"Количество натуральных чисел:{result}.");
}

Console.Write("Введите количество чисел: ");
int value = Convert.ToInt32(Console.ReadLine());
Num(value);


 // Задача 2: Пользователь вводит с клавиатуры кол-во строк и столбцов для массива. 
// Вывести массив в виде матрицы, создав "рамку" из единиц, а внутреннюю зону матрицы заполнить нулями.

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












