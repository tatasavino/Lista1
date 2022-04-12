using System;

namespace p6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Faça um programa que pergunte o preço de três produtos e informe qual produto você deve comprar, sabendo que a decisão é sempre pelo mais barato. */
 
            Console.Write("\nBom dia! Vamos começar?\n\n\tDigite o valor do primeiro produto: ");
            string n1 = Console.ReadLine();
            double numero1 = Convert.ToDouble(n1);
 
            Console.Write("\n\tDigite o valor do segundo produto: ");
            string n2 = Console.ReadLine();
            double numero2 = Convert.ToDouble(n2);
 
            Console.Write("\n\tDigite o valor do terceiro produto: ");
            string n3 = Console.ReadLine();
            double numero3 = Convert.ToDouble(n3);
 
            if (numero1 <= numero2) {
                if (numero1 <= numero3) {
                    Console.WriteLine($"\nO produto de valor '{numero1:C}' é o melhor!\n");
                } else {
                    Console.WriteLine($"\nO produto de valor '{numero3:C}' é o melhor!\n");
                }
            } else if (numero2 <= numero3) {
                Console.WriteLine($"\nO produto de valor '{numero2:C}' é o melhor!\n");
            }  else {
                Console.WriteLine($"\nO produto de valor '{numero3:C}' é o melhor!\n");
            }

        }
    }
}