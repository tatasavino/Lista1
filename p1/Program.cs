using System;

namespace p1 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Faça um programa que peça dois números, verifique (usando if e else) e imprima o maior */
 
            Console.Write("\nBom dia! Vamos começar?\n\n\tPrimeiro número: ");
            string n1 = Console.ReadLine();
            double num1 = Convert.ToDouble(n1);
 
            Console.Write("\tSegundo número: ");
            string n2 = Console.ReadLine();
            double num2 = Convert.ToDouble(n2);
 
            if (num1 > num2) {
                Console.WriteLine("\n O número '"+ num1 + "' é o maior.\n");
            } else {
                Console.WriteLine("\n O número '"+ num2 + "' é o maior.\n");
            }
 
        }
    }
}
