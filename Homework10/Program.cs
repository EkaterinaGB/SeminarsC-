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

int[] ConvertBinaryArray(int[] arrayData, int[] arrayInfo)
{
   int indexArrayInfo = 0;
   int indexArrayData = 0;
   int[] result = new int[arrayInfo.Length];

   while (indexArrayInfo < arrayInfo.Length)
   {
      int[] array = new int[arrayInfo[indexArrayInfo]];

      for (int i = 0; i < array.Length; i++)
      {
         array[i] = arrayData[indexArrayData];
         indexArrayData++;
      }

      for (int i = 0; i < array.Length; i++)
      {
         result[indexArrayInfo] += array[i] * (int)Math.Pow(2, array.Length - 1 - i);
      }
      indexArrayInfo++;
   }
   return result;
}

void PrintArray(int[] array)
{
   Console.Write($"[ ");
   for (int i = 0; i < array.Length; i++)
   {
      Console.Write($"{array[i]}");
      if (i == array.Length - 1) break;
      Console.Write($", ");
   }
   Console.Write($" ]");
   Console.WriteLine();
}

int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };
PrintArray(ConvertBinaryArray(data, info));
