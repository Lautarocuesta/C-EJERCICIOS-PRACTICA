//Ejercicio 6: Búsqueda I (ArrayList)

//Se solicita implementar el algoritmo Binary Search en C# utilizando ArrayLists.

 using System;
using System.Collections;


class Program6 {
     public static void ary () {
     var arlist = new ArrayList();
    // Agrego elementos al ArrayList 
    arlist.Add(10);
    arlist.Add(20);
    arlist.Add(30);
 }
public static int BinarySearch(ArrayList arr, int target) {
    int left = 0;
    int right = arr.Count - 1;

    while (left <= right) {
      int mid = (left + right) / 2;
      int midValue = (int)arr[mid];

      if (midValue == target) {
        return mid;
      } else if (midValue < target) {
        left = mid + 1;
      } else {
        right = mid - 1;
      }
    }

    return -1; // Element not found
  }
  public static void Main () {
    ary();
 }
  }