using System;

namespace p3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Faça um programa que verifique (usando if e else) se uma letra digitada é "F" ou "M".
           Conforme a letra escrever: F - Feminino, M - Masculino, Sexo inválido. */
 
           Console.Write("\nBom dia! Vamos começar? \n\n\t Informe seu sexo (M para Masculino, F para feminino): ");
           string se = Console.ReadLine();
           string sex = se.Substring(0,1);
           sex = sex.ToUpper();
           char sexo = Convert.ToChar(sex);
 
           if ( sexo == 'F' ) {
               Console.WriteLine("\nSeu sexo é 'Feminino'!\n");
           } else if ( sexo == 'M' ) {
               Console.WriteLine("\nSeu sexo é 'Masculino'!\n");
           } else {
               Console.WriteLine("\nSeu sexo é inválido.\n");
           }

        }
    }
}