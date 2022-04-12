using System;

namespace p13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crie um programa que peça um número ao usuário e armazene ele na variável x. 
            Depois peça outro número e armazene na variável y. Mostre esses números. 
            Em seguida, faça com que x passe a ter o valor de y, e que y passe a ter o valor de x.*/
            
            Console.Write("\nBom dia. Vamos começar?\n\n\tValor de x: ");
            string xis = Console.ReadLine();
            double x0 = Convert.ToDouble(xis);
            Console.Write("\n\tValor de y: ");
            string ipsilon = Console.ReadLine();
            double y0 = Convert.ToDouble(ipsilon);

            double x = y0;
            double y = x0;

            Console.WriteLine($"\nValores trocados com sucesso: \n\n\tx: {x} \n\ty: {y}\n");
        }
    }
}