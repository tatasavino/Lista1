using System;

namespace p16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que leia três números e mostre-os em ordem decrescente.*/
            
            Console.Write("\nBom dia! Vamos começar?\n\n\tPrimeiro número: ");
            string n1 = Console.ReadLine();
            double num1 = Convert.ToDouble(n1);

            Console.Write("\n\tSegundo número: ");
            string n2 = Console.ReadLine();
            double num2 = Convert.ToDouble(n2);

            Console.Write("\n\tTerceiro número: ");
            string n3 = Console.ReadLine();
            double num3 = Convert.ToDouble(n3);

            double[] ordem = {0, 0, 0};

            if (num1>=num2) {
                if (num1>=num3) { 
                    ordem [0] = num1;
                    if (num2<=num3) {
                        ordem [1] = num3;
                        ordem [2] = num2;                            
                    } else {
                        ordem [2] = num3;
                        ordem [1] = num2; 
                    }
                } else {
                    ordem [1] = num1;
                    ordem [2] = num2; 
                    ordem [0] = num3;
                }

            } else if (num2>=num3) {
                ordem[0] = num2;
                if (num1<=num3) {
                    ordem [1] = num3;
                    ordem [2] = num1;
                } else {
                    ordem [1] = num1;
                    ordem [2] = num3;
                }
            } else {
                ordem [2] = num1;
                ordem [1] = num2; 
                ordem [0] = num3;
            }

            Console.WriteLine($"\nOrdem decrescente: {ordem[0]} -> {ordem[1]} -> {ordem[2]}\n");

        }
    }
}
