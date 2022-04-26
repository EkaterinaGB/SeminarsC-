// Заданы 2 массива: info и data. В массиве info хранятся двоичные представления нескольких чисел (без разделителя).
// В массиве data хранится информация о количестве бит, которые занимают числа из массива info. 
// Напишите программу, которая составит массив десятичных представлений чисел массива data с учётом информации из массива info.

// Комментарий: первое число занимает 2 бита (01 -> 1); второе число занимает 3 бита (111 -> 7); 
// третье число занимает 3 бита (000 -> 0; четвёртое число занимает 1 бит (1 -> 1)

// Пример:

// входные данные:
// data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
// info = {2, 3, 3, 1 }

// выходные данные:
// 1, 7, 0, 1

// int[] ConvertBinaryArray(int[] arrayData, int[] arrayInfo)
// {
//    int indexArrayInfo = 0;
//    int indexArrayData = 0;
//    int[] result = new int[arrayInfo.Length];

//    while (indexArrayInfo < arrayInfo.Length)
//    {
//       int[] array = new int[arrayInfo[indexArrayInfo]];

//       for (int i = 0; i < array.Length; i++)
//       {
//          array[i] = arrayData[indexArrayData];
//          indexArrayData++;
//       }

//       for (int i = 0; i < array.Length; i++)
//       {
//          result[indexArrayInfo] += array[i] * (int)Math.Pow(2, array.Length - 1 - i);
//       }
//       indexArrayInfo++;
//    }
//    return result;
// }

// void PrintArray(int[] array)
// {
//    Console.Write($"[ ");
//    for (int i = 0; i < array.Length; i++)
//    {
//       Console.Write($"{array[i]}");
//       if (i == array.Length - 1) break;
//       Console.Write($", ");
//    }
//    Console.Write($" ]");
//    Console.WriteLine();
// }

// int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
// int[] info = { 2, 3, 3, 1 };
// PrintArray(ConvertBinaryArray(data, info));

// Дополнение к задаче №10:

// int CheckBinaryNum(int number) // метод проверят значения, которые вводит пользователь, являются ли они двоичными, если нет, то запрашивает снова
// {
//    while (number < -1 || number > 1)
//    {
//       Console.WriteLine($"Вы ввели число в недвоичном представлении.Введите 0 или 1: ");
//       number = Convert.ToInt32(Console.ReadLine());
//    }
//    return number;
// }

// int[] FillArrayBinaryNum() // метод заполняет массив data двоичными числами
// {
//    int item = 1;
//    int[] binaryArray = new int[item];

//    Console.WriteLine($"Введите двоичное представление чисел, используя 0 или 1: ");
//    int numUser = CheckBinaryNum(Convert.ToInt32(Console.ReadLine()));
//    if (numUser == -1)
//    {
//       Console.WriteLine($"Вы не вводили никаких цифр. Попробуйте снова: ");
//       numUser = CheckBinaryNum(Convert.ToInt32(Console.ReadLine()));
//    }

//    while (numUser != -1)
//    {
//       binaryArray[item - 1] = numUser;
//       numUser = CheckBinaryNum(Convert.ToInt32(Console.ReadLine()));
//       if (numUser == -1) break;
//       Array.Resize(ref binaryArray, binaryArray.Length + 1);
//       item++;
//    }
//    return binaryArray;
// }

// int CheckNaturalNum(int number) // метод проверяет числа, которые пользователь вводит, заполняя массим info, на натуральные
// {
//    while (number <= 0 && number != -1)
//    {
//       Console.WriteLine($"Введите натуральное число: ");
//       number = Convert.ToInt32(Console.ReadLine());
//    }
//    return number;
// }

// int[] FillArrayBitsNum() // метод заполняет массив info натуральными числами
// {
//    int item = 1;
//    int[] bitsArray = new int[item];

//    Console.WriteLine($"Введите числа, соответствующие количеству битов, которые занимают двоичные числа: ");
//    int numUser = CheckNaturalNum(Convert.ToInt32(Console.ReadLine()));
//    if (numUser == -1)
//    {
//       Console.WriteLine($"Вы не вводили никаких цифр. Попробуйте снова: ");
//       numUser = CheckNaturalNum(Convert.ToInt32(Console.ReadLine()));
//    }

//    while (numUser != -1)
//    {
//       bitsArray[item - 1] = numUser;
//       numUser = CheckNaturalNum(Convert.ToInt32(Console.ReadLine()));
//       if (numUser == -1) break;
//       Array.Resize(ref bitsArray, bitsArray.Length + 1);
//       item++;
//    }
//    return bitsArray;
// }

// int[] DiffBinBitsArray(int[] binArr, int[] bitsArr) // метод увеличивает массив data, если пользователь ввел больше значений в массив info
// {
//    int sumBitItem = 0;
//    for (int i = 0; i < bitsArr.Length; i++)
//    {
//       sumBitItem += bitsArr[i];
//    }

//    if (binArr.Length < sumBitItem)
//    {
//       int diffBinBits = sumBitItem - binArr.Length;
//       Array.Resize(ref binArr, binArr.Length + diffBinBits);
//       return binArr;
//    }
//    else return binArr;
// }

// int[] CheckBitsArray(int[] binArr, int[] bitsArr) // метод увеличивает массив info, если пользователь ввел больше значений в массив data 
// {
//    int sumBitItem = 0;
//    for (int i = 0; i < bitsArr.Length; i++)
//    {
//       sumBitItem += bitsArr[i];
//    }

//    if (binArr.Length > sumBitItem)
//    {
//       int diffBinBits = binArr.Length - sumBitItem;
//       Array.Resize(ref bitsArr, bitsArr.Length + 1);
//       bitsArr[bitsArr.Length - 1] = diffBinBits;
//       return bitsArr;
//    }
//    else return bitsArr;
// }

// void PrintArray(int[] array) // метод выводит эелементы массива в консоле
// {
//    Console.Write($"[ ");
//    for (int i = 0; i < array.Length; i++)
//    {
//       Console.Write($"{array[i]}");
//       if (i == array.Length - 1) break;
//       Console.Write($", ");
//    }
//    Console.Write($" ]");
//    Console.WriteLine();
// }

// // решение, когда пользователь сам вводит элементы data и info

// int[] data = FillArrayBinaryNum();
// int[] info = FillArrayBitsNum();
// data = DiffBinBitsArray(data, info);
// info = CheckBitsArray(data, info);

// PrintArray(ConvertBinaryDecimal(data, info));