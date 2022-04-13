// Задача 1. Сделать вывод треугольника Паскаля в виде равнобедренного треугольника.

// double Factorial (int n)
// {
//     double x = 1; 
    
//     for (int i = 1; i <= n; i++)
//     x = x * i;
    
//     return x;
// }

// void PascalTriangle ()
// {
//     Console.Write("Введите количество строк для ввода треугольника Паскаля: ");
//     int number = Convert.ToInt32(Console.ReadLine());
    
//     int j;
//     for (int i = 0; i < number; i++)
//     {
//         for (j = 0; j <= (number - i); j++) 
//         Console.Write(" "); 
        
//         for (j = 0; j <= i; j++)
//         {
//             Console.Write(" "); 
//             Console.Write(Factorial(i) / (Factorial(j) * Factorial(i - j))); 
//         }
//         Console.WriteLine();
//         Console.WriteLine(); 
//     }
//     Console.WriteLine();
// }

// PascalTriangle();
