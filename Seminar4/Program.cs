// Программа принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

/*

int SumNumber(int A)
{
    int result=0;

    int i=1;
    while (i<=A)
    {
        result=result+i;
        i++;
    }

    return result;
    
}

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 1) 
{
    Console.WriteLine("Вы ввели неверное число");
}
else 
{
    Console.WriteLine($"Сумма чисел от 1 до {number}равна {SumNumber(number)}");
}



// Программа принимает на вход число N и выдаёт произведение чисел от 1 до N.

int Factorial(int N)
{
    int result=1;

    int i=1;
    while (i<=N)
    {
        result=result*i;
        i++;
    }

    return result;
    
}

Console.WriteLine("Введите целое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number2 <= 1) 
{
    Console.WriteLine("Вы ввели неверное число");
}
else 
{
    Console.WriteLine($"Произведение чисел от 1 до {number2}равна {Factorial(number2)}");
}



//Программа принимает на вход число и выдаёт количество цифр в числе.

void Long(int N)
{
    int l = 1;
    while (Math.Abs(N / 10) >= 1)
    {
        N = N / 10;
        l++;
    }
    Console.WriteLine("Количество цифр в числе: " + l);
}

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Long(number);



// Программа выводит массив из 8 элементов,заполненный нулями и единицами в случайном порядке.

void bitArray()
{
    int[] a = new int [8];
    for(int i =0;i < 8; i++)
    {
        a[i] = new Random().Next(0,2);
        Console.Write(a[i] + "");
    }
}

bitArray();

*/