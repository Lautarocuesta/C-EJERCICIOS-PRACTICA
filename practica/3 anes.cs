using System;
using System.Collections.Generic;

class Program{
    static int Seri(string cadena, int largo)
    {
        Queue<int> digits = new Queue<int>();
        Queue<int> digits1 = new Queue<int>();
        Queue<int> digits2 = new Queue<int>();
        int result1 = 1;
        int result2 = 1;
        int resultMax = 0;

        for (int i = 0; i < cadena.Length; i++)
        {
            digits.Enqueue(cadena[i] - '0');
        }

        while (digits.Count >= largo)
        {
            for (int i = largo; i > 0; i--)
            {
                int num = digits.Dequeue();
                digits1.Enqueue(num);
            }

            for (int i = 0; i < largo; i++)
            {
                result1 *= digits.Dequeue();
            }

            for (int i = largo; i > 0; i--)
            {
                int num = digits1.Dequeue();
                digits2.Enqueue(num);
            }

            for (int i = 0; i < largo; i++)
            {
                result2 *= digits2.Dequeue();
            }

            if (result1 > result2)
            {
                resultMax = result1;
            }
            else
            {
                resultMax = result2;
            }

            result1 = 1;
            result2 = 1;
        }

        return resultMax;
    }

    public static void Main(string[] args)
    {
        string cadena = "1211313";
        int largo = 3;
        int result = Seri(cadena, largo);
        Console.WriteLine("Producto máximo de subcadenas es: " + result);
    }
}