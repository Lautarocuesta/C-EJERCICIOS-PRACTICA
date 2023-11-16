//Se solicita implementar el algoritmo Lineal Search en C# utilizando ArrayLists.
using System;
using System.Collections;
using System.Globalization;

class LinearSearch
{
    static bool LinearSearchInArrayList(ArrayList list, int num)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if ((int)list[i] == num)
            {
                return true;
            }
        }
        return false;
    }

    public static void Main(string[] args)
    {
        ArrayList list = new ArrayList() { 4, 7, 1, 0 };
        int target = 3;

        if (LinearSearchInArrayList(list, target))
        {
            Console.WriteLine("Número encontrado");
        }
        else
        {
            Console.WriteLine("Número no encontrado");
        }
    }
}