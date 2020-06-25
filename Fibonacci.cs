using System;
namespace Aula25Recursividade
{
    public class Fibonacci
    {
        //0,1,1,2,3,5,8,13,21,34,55,89,144,233
        public void GerarFibonacci(int n1, int n2, int vezes){
            if(vezes > 0){
                Console.WriteLine(n1);
                GerarFibonacci(n2, n1 + n2,vezes - 1);
            }
        }
        //5 = 5*4*3*2*1
        public int GerarFatorial(int numero){
            if(numero == 1){
                return 1;
            }else{
                return numero * GerarFatorial(numero - 1);
            }
                
        }
        


    }
}