using System;

namespace p17
{
    internal class Program
    {
        static void Main(string[] args)
        {
             /*Faça um programa que calcule o IMC do usuário a partir do de seu peso e de sua altura,
            de acordo com a fórmula  IMC = PESO / ALTURA * ALTURA. A partir do valor do IMC calculado, 
            apresente a mensagem para o usuário conforma a tabela a seguir:
            <18.5 - Peso baixo
            18.5 a 25 - Peso normal
            25 a 30 - Sobrepeso
            30 a 35 - Obesidade
            35 a 40 - Obesidade severa
            >40 - Obesidade mórbida
            if ((imc >= 18.5) && (imc<25)*/
 
            Console.WriteLine("\nBem vindo, usuário! Vamos começar?\nPeso: ");
            string pes = Console.ReadLine();
            double peso = Convert.ToDouble(pes);
 
            Console.WriteLine("\nAltura: ");
            string alt = Console.ReadLine();
            double altura = Convert.ToDouble(alt);
 
            double imc = peso / (altura * altura);
 
            if (imc < 30) {
                if (imc >= 25) {
                    Console.WriteLine("\nVocê está com sobrepeso!\n");
                } else {
                    if (imc >= 18.5) {
                        Console.WriteLine("\nVocê está em seu peso normal!\n");
                    } else {
                        Console.WriteLine("\nVocê está abaixo do peso!\n");
                    }
                }
            } else {
                if (imc < 40) {
                    Console.WriteLine("\nVocê está com obesidade severa!\n");
                } else {
                    Console.WriteLine("\nVocê está com obesidade mórbida!\n");
                }
            }

        }
    }
}
