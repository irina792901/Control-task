namespace MyMethods;
using System;
using static System.Console;
public class StringArrays
{
    public static void PrintResult(string[] array)
    {
        PrintStringArray(array);
        Write(" → ");
        GetNewArrayFromShortStringsArray(array, 3);
        Write("\n");
    }

    public static void PrintStringArray(string[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"\"{array[i]}\"");
            if
                (i != array.Length - 1) Console.Write(", ");
        }
        Console.Write("]");
    }

    public static void GetNewArrayFromShortStringsArray(string[] array, int size)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length < size + 1) count++;
        }
        if (count > 0)
        {
            string[] newArray = new string[count];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length < size + 1)
                {
                    newArray[index] = array[i];
                    index++;
                }
            }
            PrintStringArray(newArray);
        }
        else Write("[]");
    }

}

