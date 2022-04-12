using System;

namespace p8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que leia 2 números e em seguida pergunte ao usuário qual operação ele deseja realizar (+, -, *, /). 
            O resultado da operação escolhida deve ser acompanhado de uma frase que se diga o númeor é: 
            - Par ou ímpar;
            - Positivo ou negativo */
 
            Console.Beep();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nBom dia! Vamos começar?\n\n \tInforme um número: ");
            string n1 = Console.ReadLine();
            double num1 = Convert.ToDouble(n1);
            Console.Write("\n\tInforme outro número: ");
            string n2 = Console.ReadLine();
            double num2 = Convert.ToDouble(n2);
            Console.Write("\n\tInforme qual a operação matemática que deseja fazer (+, -, *, /): ");
            string r = Console.ReadLine();
            char res = Convert.ToChar(r);
 
            double conta = 0;
 
            switch (res) {
                case '+':
                    conta = num1 + num2;
                    break;
                case '-':
                    conta = num1 - num2;
                    break;
                case '/':
                    conta = num1 / num2;
                    break;
                case '*':
                    conta = num1 * num2;
                    break;
                default:
                    Console.Write("\n\nOpção inválida.");
                    break;
            }
 
            if (conta%2==0)  {
                if (conta!=0) {
                    Console.Write("\n\nO resultado é par.\n\n");
                } else {
                    Console.Write("\n\nO resultado é nulo.\n\n");
                }
            } else {
                Console.Write("\n\nO resultado é ímpar.\n\n");
            }
 
            if (conta<=0)  {
                if (conta<0) {
                    Console.Write("\nO resultado é negativo.\n\n");
                } else {
                }
            } else {
                Console.Write("\nO resultado é positivo.\n\n");
            }

        }
    }
}
