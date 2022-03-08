//Программа принимает на вход пятизначное число и проверяет, является ли она палиндромом.

// Вариант 1:

/*

void Palidrom(int num)
{
    int figure1 = num / 10000;
    int figure2 = num % 10000 / 1000;
    int figure3 = num % 100 / 10;
    int figure4 = num % 10;

    if(figure1 == figure4 && figure2 == figure3)
    {
        Console.WriteLine("Данное число является палиндромом.");
    }
    else
    {
        Console.WriteLine("Данное число не является палиндромом.");
    }
}

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Palidrom(number);

// Вариант 2:

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
