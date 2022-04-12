using System;

namespace p5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Faça um programa para a leitura de duas notas parciais de um aluno.
           A mensagem "Aprovado", se a média alcançada for maior ou igual a sete;
           A mensagem "Aprovado com Louvor", se a média for igual a dez;
           A mensagem "Reprovado" se a média for menor que sete.*/
 
            Console.Write("\nBom dia! Vamos começar? \n\n\t Digite um número: ");
            string n1 = Console.ReadLine();
            double numero1 = Convert.ToDouble(n1);
 
            Console.Write("\n\t Digite outro número: ");
            string n2 = Console.ReadLine();
            double numero2 = Convert.ToDouble(n2);
 
            double media = (numero1 + numero2) / 2;
 
            if ( media >= 7 ) {
                if (media != 10) {
                    Console.WriteLine("\nAprovado!\n");
                } else {
                    Console.WriteLine("\nAprovado com sucesso!\n");
                }
            } else {
                Console.WriteLine("\nReprovado!\n");
            }

        }
    }
}
