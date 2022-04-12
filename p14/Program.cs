using System;

namespace p14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que leia três números, verifique (usando if e else), e mostre o maior deles.*/
            Console.Write("\nBom dia. Vamos começar?\n\n\tPrimeiro número: ");
            string n1 = Console.ReadLine();
            double num1 = Convert.ToDouble(n1);

            Console.Write("\n\tSegundo número: ");
            string n2 = Console.ReadLine();
            double num2 = Convert.ToDouble(n2);

            Console.Write("\n\tTerceiro número: ");
            string n3 = Console.ReadLine();
            double num3 = Convert.ToDouble(n3);

            if (num1>=num2) {
                    if (num1>=num3) {
                        Console.WriteLine($"\nO maior número é: {num1}\n");
                    } else {
                        Console.WriteLine($"\nO maior número é: {num3}\n");
                    }
            } else if (num2>=num3) {
                    Console.WriteLine($"\nO maior número é: {num2}\n");
            } else {
                Console.WriteLine($"\nO maior número é: {num3}\n");
            }
        }
    }
}
