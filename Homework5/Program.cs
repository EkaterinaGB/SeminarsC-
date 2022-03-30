// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

/*
Console.WriteLine("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];

for (int i = 0; i < num; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i] + " ");
}
int SumNeg(int[] array) 
{
    int count = array.Length;
    int neg = 0;
    for (int i = 0; i < count; i++)
    {
        if (array[i] % 2 == 0) neg ++;
    }
    return neg;
}
int number = SumNeg(array);
Console.WriteLine($"Количество чётных чисел в массиве {number} ");


// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int size = new Random().Next(0,20);

int[] Array( int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

void Array2(int[] arr)
{
    int sum = 0;
    Console.WriteLine();
    for (int i = 0; i < size; i++)
    {
        Console.Write(arr[i] + " ");
        if (i % 2 > 0) sum += arr[i];
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма чисел, стоящих на нечетной позиции, соcтаваляет {sum} ");
    Console.WriteLine();
}

Array2(Array(size));



// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Write("Дан массив: ");
void FillArray(double[] newArray)
{
    
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = new Random().NextDouble() * 100;
        Console.Write("{0,6:F2}",newArray[i]); 
    }
    Console.WriteLine();

    double max = newArray[0];
    double min = newArray[0];
   
    for (int i = 0; i < newArray.Length; i++)
    {
        if(newArray[i] > max) max = newArray[i];
        if(newArray[i] < min) min = newArray[i];


    }
    Console.Write($"Разница между максимальным ({max:F2}) и минимальным ({min:F2}) элементами массива равна {max - min:F2}");
    
}

double[] Array = new double[3];
FillArray(Array);

*/

