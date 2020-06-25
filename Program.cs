using System;

namespace Aula25Recursividade
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Fibonacci calculo = new Fibonacci();
            calculo.GerarFibonacci(0,1,20);
            Console.WriteLine(calculo.GerarFatorial(5));
            
        }
    }
}
