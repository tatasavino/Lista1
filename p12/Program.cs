using System;

namespace p12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que pergunte o dia, o mês e o ano do aniversário de uma pessoa e diga 
            a data é válida ou não. Caso não seja, diga o motivo. Para simplificar, considere que todos
            os meses possuem 30 dias.*/

            Console.Write("\nBom dia! Vamos começar?\nSobre o nascimento de alguém, nos informe...\n\n\tO dia: ");
            string d = Console.ReadLine();
            int dia = Convert.ToInt16(d);

            Console.Write("\n\tO mês: ");
            string m = Console.ReadLine();
            int mes = Convert.ToInt16(m);

            Console.Write("\n\tO ano: ");
            string a = Console.ReadLine();
            int ano = Convert.ToInt16(a);

            if ((dia>30)|(dia<=0)) {
                Console.WriteLine("\nDia inválido. O número é maior que 30 ou menor que zero.");
            } else {
                Console.WriteLine("\nDia válido.");
            }

            if ((mes>12)|(mes<=0)) {
                Console.WriteLine("Mês inválido. O número é maior que 12 ou menor que zero.\n");
            } else {
                 Console.WriteLine("Mês válido.\n");
            }

        }
    }
}
