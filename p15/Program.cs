using System;

namespace p15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que leia três números, verifique (usando if e else)
            e mostre o maior e o menor deles.*/

            Console.Write("\nBom dia! Vamos começar?\n\n\tPrimeiro número: ");
            string n1 = Console.ReadLine();
            double num1 = Convert.ToDouble(n1);

            Console.Write("\n\tSegundo número: ");
            string n2 = Console.ReadLine();
            double num2 = Convert.ToDouble(n2);

            Console.Write("\n\tTerceiro número: ");
            string n3 = Console.ReadLine();
            double num3 = Convert.ToDouble(n3);

            double maior = 0;
            double menor = 0;

            if (num1>=num2) {
                if (num1>=num3) {
                    maior = num1;
                    if (num2<=num3) {
                        menor = num2;
                    } else {
                        menor = num3;
                    }
                } else {
                    maior = num3;
                    menor = num2;
                }
            } else if (num2>=num3) {
                maior = num2;
                if (num1<=num3) {
                    menor = num1;
                } else {
                    menor = num3;
                }
            } else {
                maior = num3;
                menor = num1;
            }

            Console.WriteLine($"\nMaior: {maior}\n");
            Console.WriteLine($"Menor: {menor}\n");
        }
    }
}
