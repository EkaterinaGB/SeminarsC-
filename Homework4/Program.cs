// Программа принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
int Degree(int A, int B)
{
    int result = 1;
    while (B--> 0) result *= A;
    for (int i = 1; i <= B; i++)
    {
        result = result * A;
        Console.WriteLine(result);
    }
    return result;

}

Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int B = Convert.ToInt32(Console.ReadLine());
int Deg = Degree(A,B);
Console.WriteLine($"A ^ B = {Deg}");





// Программа принимает на вход число и выдаёт сумму цифр в числе.

int Sum(int N)
{
    int sum = 0;
    while (N >= 1)
    {
        int B = N % 10;
        sum = sum + B;
        N = N / 10;
    }
    
    return sum;
}

Console.WriteLine("Введите целое положительное число ");
int number = Convert.ToInt32(Console.ReadLine());
int Sum1 = Sum(number);
Console.WriteLine($"Сумма цифр в числе {number} = {Sum1}");





// Программа задаёт массив из 8 элементов и выводит их на экран.

int N = 8;

int[] Array(int a)
{
    int[] arr = new int[a];
    for (int i = 0; i < a; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        System.Console.Write($"{array[i]} ");
}

PrintArray(Array(N));

*/



