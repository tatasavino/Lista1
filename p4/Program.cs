using System;

namespace p4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Faça um programa que verifique (usando if ou else) se uma letra digitada é vogal ou consoante. */
 
           Console.Write("\nBom dia! Vamos começar? \n\n\tDigite uma letra: ");
           string l = Console.ReadLine();
           char letra = Convert.ToChar(l);
 
           if ((letra == 'a') | (letra == 'e') | (letra == 'i') | (letra == 'o') | (letra == 'u')) {
               Console.WriteLine("\nA letra digitada é uma vogal!\n");
           } else {
               Console.WriteLine("\nA letra digitada é uma consoante!\n");
           }
 
           /*//ou faça isso:
           string vogais = "aeiou"
           
           if (vogais.Contains(letra)) {
               } else if (IsLetter(letra)) {
               } else {
               }*/ 

        }
    }
}
