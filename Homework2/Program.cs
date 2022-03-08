/*

// Програма принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


int SecondNum(int number)
{
    if ( number >99 && number < 1000)
    {
       
        int num = number % 100;
        return num / 10;
    }
       else
       {
           return - 1;
       }
    
}

Console.WriteLine("Введите трёхзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вторая цифра в числе равно: " + SecondNum(n));


//Программа выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


void thirdDigit(int number)
{
    if(number > 99)
    {
        while(number >999)
        {
           number = number / 10;
        
        }

         number = number % 10;
        Console.WriteLine("Третья цифра в числе равна: " + number);
    }
    else
    {
        Console.WriteLine("В данном числе нет третьей цифры");
        

    }
}
Console.WriteLine("Введите целое число: ");
int n = Convert.ToInt32(Console.ReadLine());
thirdDigit(n);


// Программа принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


void Weekend(int day)
{
    if(day >0 && day <6)
    {
        Console.WriteLine("Будни");
    }
    if(day == 6 || day == 7)
    {
        Console.WriteLine("Выходные");
    }
    if(day < 1 || day > 7)
    {
        Console.WriteLine("Нет такого дня недели");
    }
}
Console.WriteLine("Введите число соответствующее дню недели: ");
int n = Convert.ToInt32(Console.ReadLine());
Weekend(n);



//Программа принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Palidrom(int num)
{
    int NumberSleva = num / 10000;
    int NumberSprava = num % 10;
    
    if(NumberSleva == NumberSprava)
    {
        NumberSleva = (num / 1000) % 10;
        NumberSprava = (num % 100) / 10;
        if(NumberSleva == NumberSprava)
        {
            Console.WriteLine("Введеное число является палиндом.");
        }
        else
        {
            Console.WriteLine("Введеное число не является палиндромом.");
        }
    }
    else
    {
        Console.WriteLine("Введеное число не является палидромом.");
    }
}
Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Palidrom(number);



// Программа принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double distance3D(double x1,double y1,double z1,double x2, double y2,double z2)
{
    double xDistance = x2 - x1;
    double yDistance = y2 - y1;
    double zDistance = z2 - z1;
    double resalt = Math.Sqrt(Math.Pow(xDistance,2) + Math.Pow(yDistance,2) + Math.Pow(zDistance,2));
    return resalt;
}


double xA,yA,zA,xB,yB,zB;
Console.WriteLine("Введите координату x точки А: ");
xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y точки A: ");
yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z точки А: ");
zA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x точки B: ");
xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y точки B: ");
yB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z точки B: ");
zB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(distance3D(xA,yA,zA,xB,yB,zB));



// Программа которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.



Console.WriteLine("Введите число для вывода таблицы кубов: ");
int number = Convert.ToInt32(Console.ReadLine());
int index = 1;

while(index <= number)
{
    int KubNumber = Convert.ToInt32(Math.Pow(index,3));
    Console.Write(KubNumber + " ");
    index = index + 1;
}

*/