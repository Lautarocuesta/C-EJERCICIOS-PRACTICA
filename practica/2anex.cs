using System;
using System.Collections.Generic;

class Program {
static int toAnyBase(string num,int basee){
     List<char> dig = new List<char>(); 
     int resultado = 0;
     for(int i=0 ; i< num.Length;i++){
        dig.Add(num[i]-'0');
     }
     for(int i=dig.Count-1; i>=0 ;i--){
     resultado += (int) (dig[dig.Count -1 -i]* Math.Pow(basee,i));
        }
        return resultado;
}
public static void Main(string[]args){
    string num = "22";
    int basee = 3;
    int resultado = toAnyBase(num,basee);
    Console.WriteLine($"{num}en base {basee} es = {resul}");
}

}