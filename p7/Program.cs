using System;

namespace p7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Faça um programa que pergunte em que turno você estuda. Para digitar M - matutino, V - vespertino, ou N - noturno. Imprima a mensagem "Bom dia!", "Boa Tarde!", "Boa Noite!" ou "Valor inválido."*/
            Console.Write("\nVamos começar? \n\n\t Em que turno você estuda? (Matutino, vespertino ou noturno): ");
           string tu = Console.ReadLine();
           string turn = tu.Substring(0,1);
           turn = turn.ToUpper();
           char turno = Convert.ToChar(turn);
 
           if ( turno == 'M' ) {
               Console.WriteLine("\nBoa manhã!\n");
           } else if ( turno == 'V' ) {
               Console.WriteLine("\nBoa tarde!\n");
           } else if ( turno == 'N' ) {
               Console.WriteLine("\nBoa noite!\n");
           } else {
               Console.WriteLine("\nTurno inválido.\n");
           }

        }
    }
}
