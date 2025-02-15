using System;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main(string[] args)
    {
        var num = 6;
        var sorteddesc = new int[0];
        var sortedasc = new int[0];

        var array = GetArrayFromConsole(ref num);

        SortArray(array,out sorteddesc,out sortedasc);
    }
    static int[] GetArrayFromConsole(ref int num)
    {
        var result = new int[num];

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0}", i + 1);
            result[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Ваш массив:");

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine(result[i]);
        }
        return result;
    }

    static void SortArray(int[] array, out int[] sorteddesc, out int[] sortedasc)
    {
        sorteddesc = SortArrayDesc(array);

        sortedasc = SortArrayAsc(array);

    }

    static int[] SortArrayAsc(int[] array)
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

        Console.WriteLine("Массив после сортировки по возрастанию:");

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }

        return array;
    }

    static int[] SortArrayDesc(int[] array)
    {
        int k = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    k = array[i];
                    array[i] = array[j];
                    array[j] = k;
                }
            }

        }

        Console.WriteLine("Массив после сортировки по убыванию:");

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }

        return array;
    }
}