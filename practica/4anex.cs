using System;
using System.Linq;//nuevp
using System.Collections.Generic;

class Program {
  static int tirada(){
    List<int> dados = new List<int>();
    Random numr = new Random();
    for (int i = 0; i < 4; i++){
      int num = numr.Next(1, 6);
      dados.Add(num);
    }
    int min = dados.Min();
    dados.Remove(min);
    int sum = 0;
    for (int i = 0; i < dados.Count; i++){
      sum += dados[i];
    }
    return sum;
  }
  static List<int> gameGenerator () {
    List<int> puntos = new List<int>();
    for(int i = 0; i < 6; i++){
      int suma = tirarDados();
      puntos.Add(suma);
    }
    int constitucion = puntos[2];
    int modificador = 10 - constitucion;
    int golpe = 10 + modificador;
    puntos.Add(golpe);
    return puntos;
  }
  public static void Main (string[] args) {
    List<int>puntos = gameGenerator();
    Console.WriteLine("fza = " + puntos[0]);
    Console.WriteLine("destreza = " + puntos[1]);
    Console.WriteLine("constitucion = " + puntos[2]);
    Console.WriteLine("inteligencia = " + puntos[3]);
    Console.WriteLine("sabiduria = " + puntos[4]);
    Console.WriteLine("carisma = " + puntos[5]);
    Console.WriteLine("golpe = " + puntos[6]);
  }
}