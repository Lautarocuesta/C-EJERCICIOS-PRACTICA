//Ejercicio 9: Ordenación (ArrayList)
//Se solicita implementar el algoritmo BubbleSort en C# utilizando ArrayLists.
using System;
using System.Collections; 
class BubbleSort
{
 static void BubbleSortArrayList(ArrayList list)
 {
 for (int i = 0; i < list.Count - 1; i++)
  {
  for (int j = 0;  j < list.Count - i - 1; j++)
  {
      if ((int)list[j] > (int)list[j + 1])
                {
                    int temp = (int)list[j];
                    list[j] = (int)list[j + 1];
                    list[j + 1] = temp;
                }
            }
        }
    }   
 
    public static void Main(string[] args)
 { 
ArrayList nums = new ArrayList(){9,2,5,7,1};


Console.WriteLine("array original:");
foreach (var num in nums)
{
  Console.Write(num + "");
}
Console.WriteLine();

BubbleSortArrayList(nums);  
 Console.WriteLine("Array ordenado:");
        foreach (var num in nums)
        {
          Console.Write(num + "");
 }
 }
}