using System;

namespace p18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que leia duas notas parciais obtidas por um aluno, calcule a sua média e lhe atribua um conceito conforme a tabela abaixo:

            Média de aproveitamento		Conceito 
            Entre 9.0 e 10.0 		A
            Entre 7.5 e 9.0			B
            Entre 6.0 e 7.5			C
            Entre 4.0 e 6.0			D
            Entre 4.0 e 0			E*/

            Console.Write("\n(Bom dia. Vamos começar?)\n\n\tPrimeira nota: ");
            string n1 = Console.ReadLine();
            double nota1 = Convert.ToDouble(n1);

            Console.Write("\n\tSegunda nota: ");
            string n2 = Console.ReadLine();
            double nota2 = Convert.ToDouble(n2);

            double media = (nota1 + nota2)/2;

            Console.Write("\nConceito: ");
            if (media>=6.0) {
                if (media<9.0) {
                    if (media<7.5) {
                        Console.WriteLine("C\n");
                    } else {
                        Console.WriteLine("B\n");
                    }
                } else {
                    Console.WriteLine("A\n");
                }
            } else {
                if (media<4.0) {
                    Console.WriteLine("E\n");
                } else {
                    Console.WriteLine("D\n");
                }
            }

        }
    }
}