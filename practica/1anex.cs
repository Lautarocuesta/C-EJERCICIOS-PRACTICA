using System;
using System.Collections.Generic;

class Program{
    static string Atbash(string input){
        List<char> palabraCifrada = new List<char>();
        List<char> abc = new List<char>();
        for(char letra= 'a'; letra <= 'z';letra++){
          abc.Add(letra);
        }
        for (int i = 0; i < input.Length; i++){
          int index = abc.IndexOf(input[i]);
          int indexOpuesto = 26 - index - 1;
          palabraCifrada.Add(abc[indexOpuesto]);
        }
      return new string(palabraCifrada.ToArray());
    }

  public static void Main(string[] args){
    string palabra = "hola";
    string resultado = Atbash(palabra);
    Console.WriteLine("palabra cifrada: " + resultado);
  } 
}
