// Задайте массив из 12 элементов, 
//заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

/*
int[] mass = new int[12];
int pos =0, neg = 0;
for (int i = 0; i < 12; i++)
{
    mass[i] = new Random().Next(-9,10);
    if (mass[i] > 0) pos = mass[i] + pos;
    else neg = neg + mass[i];
    Console.WriteLine(mass [i]);
}
Console.WriteLine($"положительные из {pos} отрицательные из {neg}");



// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

int[] mass = new int[12];
for (int i = 0; i < 12; i++)
{
    mass[i] = new Random().Next(-9, 10);
    Console.Write(mass[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < 12; i++)
{
    Console.Write((mass[i] * -1) + " ");

}



// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

int[] array = new int[25];
int tumbler = 0;
for (int i = 0; i < 25; i ++)
{
    array[i] = new Random().Next(1,30);
    Console.Write(array[i] + " ");   
}
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < 25; i++)
{
    if (array[i] == num)
    {
        Console.WriteLine("Данное число присутствует в массиве.");
        tumbler = 1;
        break;
    }
}
if (tumbler == 0) Console.WriteLine("Данного числа в массиве нет.");



// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int[] array = new int[123];
int count = 0;
for (int i = 0; i < 123; i++)
{
    array[i] = new Random().Next(1, 1000);
    if (array[i] < 100 && array[i] > 9) count++;
}
Console.WriteLine(count);



// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

Console.WriteLine("Введите длину массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];

int dlina = 1;
if (num/2 == 0) dlina = 0;
int[] array2 = new int [(num/2)+ dlina];

for (int i = 0; i < num; i++)
{
    array[i] = i + 1;
    Console.Write(array[i] + " ");
}
Console.WriteLine();
for (int i = 0; i < ((num/2) + dlina); i++)
{
    array2[i] = array[i] * (array[num-i-1]);
    if (i == num-i-1) array2[i] = array[i];
    Console.Write(array2[i] + " ");
}

*/
