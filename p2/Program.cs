using System;

namespace p2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Faça um programa que peça um valor e mostre na tela se o valor é positivo ou negativo */
 
           Console.Write("\nBom dia! Vamos começar? \n\n\tDigite o número: ");
           string n = Console.ReadLine();
           double num = Convert.ToDouble(n);
 
           if ( num > 0 ) {
            Console.WriteLine("\nO número digitado é positivo.\n");
           } else if ( num < 0) {
            Console.WriteLine("\nO número digitado é negativo.\n");
           } else {
               Console.WriteLine("\nO número digitado é nulo.\n");
           }

        }
    }
}