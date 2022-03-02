/*
//1 задача:
Console.Write("Введите целое число");
int value = Convert.ToInt32(Console.ReadLine());

int kvadrat_value = value * value;

Console.Write("Квадрат данного числа равен ");
Console.Write(value*value);


Console.Write("Введите первое целое число");
int value1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число");
int value2 = Convert.ToInt32(Console.ReadLine());
int kvadrat_value2 = value2 * value2;
if(kvadrat_value2 == value1)
{
    Console.WriteLine("Квадрат втрого числа соответствует первому");
}
else
{
    Console.WriteLine("Искомых соответствий не выявлено");
}

//3 задача:

Console.Write("Введите номер дня недели");
int namber = Convert.ToInt32(Console.ReadLine());

switch (namber)
{
    case 1:
    {
        Console.WriteLine("Понедельник");
        break;
    }
    case 2:
    {
        Console.WriteLine("Вторник");
        break;
    }

    default:
    {
        Console.WriteLine("Error!");
        break;
    }
}




if(namber =< 7 && namber >= 1)
{
    if(namber == 1)
    {
        Console.WriteLine("Понедельник");
    }
    if(namber == 2)
    {
        Console.WriteLine("Вторник");
    }
}
else
{
    Console.WriteLine("Такого дня недели не существует");
}

/*
//4 задача:

Console.Write("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());

int neg_n = n*(-1);

while(neg_n <= 1)
{
    Console.Write(neg_n +" ");
    neg_n+=3;
}

*/