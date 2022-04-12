using System;

namespace p22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um Programa que peça um número correspondente a um determinado ano e em 
            seguida informe se este ano é ou não bissexto. Dica: simplificando, um ano é 
            bissexto se ele é divisível por 4 e não é divisível por 100. Se for divisível 
            100, ele só é bissexto se for divisível por 400, caso contrário, não é bissexto.*/
            
            Console.Write("\nÉ ano bissexto ou não é?\nVamos conferir?\n\n\tQual é o ano? ");
            string a = Console.ReadLine();
            int ano = Convert.ToInt32(a);

            if (ano%4==0) {
                if (ano%100==0) {
                    if (ano%400==0){
                        Console.WriteLine("\nÉ bissexto :)\n");
                    } else {
                        Console.WriteLine("\nNão é bissexto :(\n");
                    }
                } else {
                    Console.WriteLine("\nÉ bissexto :)\n");
                }
            } else {
                Console.WriteLine("\nNão é bissexto :(\n");
            }
        }
    }
}
