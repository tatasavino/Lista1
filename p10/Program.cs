using System;

namespace p10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que pergunte o raio de uma circunferência e em seguida mostre o diâmetro,
            o comprimento e área da circunferência.*/

            Console.Write("\nBom dia! Vamos começar?\n\n\tQual é o raio da circunferência? ");
            string r = Console.ReadLine();
            double raio = Convert.ToDouble(r);

            double diametro = (raio * 2) ;
            double perimetro = (raio * 6.28) ;
            double area = ((raio * raio)* 3.14);

            Console.WriteLine($"\nDiâmetro: {diametro} ;");
            Console.WriteLine($"Perímetro: {perimetro} ;");
            Console.WriteLine($"Área: {area}.\n");
        }
    }
}