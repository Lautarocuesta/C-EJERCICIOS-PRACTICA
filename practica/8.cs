//Ejercicio 8: Ordenación (ArrayList)
//Se solicita implementar el algoritmo SelectionSort en C# utilizando ArrayLists.
using System;
using System.Collections;
using System.Linq;
class Selection1Sort
{
     
    
static void SelectionSort(ArrayList)
{
    int length = list.Count;  

           for(int i = 0; i < length;i++) 
        {
                int minIndex = i;

                for (int j = i + 1; j < length; j++)
                {
                    if ((int)list[j] < (int)list[minIndex])
                    { 
                        int minIndex = j;   
                    }
                    }
                object temp = list[i];
                list[i] = list[minIndex];
                list[minIndex] = temp;
                
                    

                    }
                }

    public static void Main(string[] args)
    {
       Arraylist nums = new Arraylist() {2,4,7,8};
      Console.WriteLine("Array original:");
        foreach (var num in nums)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        SelectionSort(nums);

        Console.WriteLine("Array ordenado:");
        foreach (var num in nums)
        {
            Console.Write(num + " ");
        }
    }
}