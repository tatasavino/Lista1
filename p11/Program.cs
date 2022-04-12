using System;

namespace p11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Para doar sangue é necessário ter entre 18 e 67 anos. 
            Faça um programa que pergunte a idade de uma pessoa e diga se ela pode doar sangue ou não. */

            Console.Write("\nDoação de sangue.\n\n\tIdade: ");
            string age = Console.ReadLine();
            int idade = Convert.ToInt16(age);

            if ((idade>=18)&(idade<=67)) {
                Console.WriteLine("\nVocê pode doar sangue.\n");
            } else {
                Console.WriteLine("\nVocê não pode doar sangue.\n");
            }
        }
    }
}
