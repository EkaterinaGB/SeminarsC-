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

*/