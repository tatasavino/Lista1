using System;

namespace p20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que peça os 3 lados de um triângulo. O programa deverá informar se
             os valores podem ser um triângulo. Indique, caso os lados formem um triângulo, se o 
             mesmo é equilátero, isósceles ou escaleno. Dicas:

	        Triangulo é viável quando a soma de quaisquer dos dois lados é maior que o terceiro.
	        Triângulo equilátero possui três lados iguais;
	        Triângulo isósceles possui quaisquer dois lados iguais;
	        Triângulo escaleno possui três lados diferentes.*/

            Console.Write("\nBom dia! Vamos começar?\n(Triângulo)\n\n\tLado 1: ");
            string l1 = Console.ReadLine();
            double lado1 = Convert.ToDouble(l1);

            Console.Write("\n\tLado 2: ");
            string l2 = Console.ReadLine();
            double lado2 = Convert.ToDouble(l2);

            Console.Write("\n\tLado 3: ");
            string l3 = Console.ReadLine();
            double lado3 = Convert.ToDouble(l3);

            if ((lado1 < lado2 + lado3)&(lado2 < lado1 + lado3)&(lado3 < lado2 + lado1)) {
                Console.WriteLine("\nÉ um triângulo.");
                if ((lado1==lado2)) {
                    if (lado2==lado3) {
                        Console.WriteLine("\nÉ equilátero.\n");
                    } else {
                        Console.WriteLine("\nÉ isósceles.\n");
                    }
                } else if ((lado1==lado3)|(lado2==lado3)){
                    Console.WriteLine("\nÉ isósceles.\n");
                }  else {
                    Console.WriteLine("\nÉ escaleno.\n");
                }

            } else {
                Console.WriteLine("\nNão é um triângulo.\n");
            }
        }
    }
}