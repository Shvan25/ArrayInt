using System;

class Program
{
    static void Main(string[] args)
    {
        var num = 6;

        var array = GetArrayFromConsole(ref num);

        var sortarray = SortArray(array);
    }
    static int[] GetArrayFromConsole(ref int num)
    {
        var result = new int[num];

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine(result[i]);
        }

        return result;
    }

    static int[] SortArray(int[] array)
    {
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (array[i] < array[j])
                {
                    k = array[i];
                    array[i] = array[j];
                    array[j] = k;
                }
            }

        }
        Console.WriteLine("Массив после сортировки:");

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }

        return array;
    }
}