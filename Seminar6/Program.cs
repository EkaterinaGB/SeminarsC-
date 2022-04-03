// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.


// void Triangle(int a,int b,int c)
// {
//     if (a <b + c && b < a + c && c < b + c)
//     {
//         Console.Write("Такой треугодник может существовать.");
//     }
//     else Console.WriteLine("Такого треугольника не существует.");
// }

// Console.WriteLine("Введите длину первой стороны треугольника: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите длину второй стороны треугольника: ");
// int numB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите длину третьей стороны треугольника: ");
// int numC = Convert.ToInt32(Console.ReadLine());

// Triangle(numA,numB,numC);



// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// void Binar(int num)
// {
//     string answer = "";
//     while (num > 0)
//     {
//         answer = Convert.ToString(num % 2) + answer;
//         num = num / 2;
//      }
//      Console.WriteLine(answer);
// }
// Console.WriteLine("Введите число: ");
// int Num = Convert.ToInt32(Console.ReadLine());
// Binar(Num);

// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

// void Fibbon(int num)
// {
//     int[] array = new int[num];
//     array[0] = 0;
//     array[1] = 1;
//     Console.Write("0 1 ");
//     for (int i = 2; i < num; i++)
//     {
//         array[i] = array[i - 1] + array[i - 2];
//         Console.Write(array[i] + " ");
//     }

// }
// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Fibbon(n);

// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования (3,4)

int[,] matrix = new int[3, 4];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
