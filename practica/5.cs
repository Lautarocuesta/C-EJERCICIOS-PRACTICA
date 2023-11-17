using System;
using System.Collections; 

class Program5{
    public static void Main(){
        correrpro();
    }
      
       public static void correrpro()
    {
        Queue<int> myQueue = new Queue<int>();
          Queue<int> colaOrdenada = new Queue<int>();
          Console.WriteLine("coloca el numero aca:");
          int cantidadelems = int.Parse(Console.ReadLine());

          for(int i = 0; i<cantidadelems;i++){
            Console.WriteLine($"ingrese valor  {i+1}:");
            int value= int.Parse(Console.ReadLine());
                myQueue.Enqueue(value);
          }
          Console.WriteLine("ahora 1 o -1:");
          int nro = int.Parse(Console.ReadLine());
          while(myQueue.Count > 0){
                int num = myQueue.Dequeue();
                if(myQueue.count > 0){
                    int nro2 = myQueue.Dequeue();
                    if(nro==1 && nro> nro2){
                         {
                    colaOrdenada.Enqueue(nro2);
                    myQueue.Enqueue(num);
                }
                else if (nro == -1 && num < nro2)
                {
                    colaOrdenada.Enqueue(nro2);
                    myQueue.Enqueue(nro);
                }
                else
                {
                    colaOrdenada.Enqueue(nro);
                    myQueue.Enqueue(nro2);
                }
            }
            else
            {
                colaOrdenada.Enqueue(nro);
            }
        }

        while (colaOrdenada.Count > 0)
        {
            Console.WriteLine(colaOrdenada.Dequeue());
        }
    

    }

                    
                
          
         