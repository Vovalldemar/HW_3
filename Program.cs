using System;

class Program
{
    static void Main()
    {

        //Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

        
        int[] array = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Source massive:");
        PrintArray(array);

        Console.WriteLine("\n Return Massive");
        PrintArrayReverse(array, array.Length - 1);
    }

    static void PrintArray(int[] array)
    {
        Console.WriteLine("[" + string.Join(", ", array) + "]");
    }

    static void PrintArrayReverse(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.WriteLine(array[index]);
            PrintArrayReverse(array, index - 1);
        }
    }
}
