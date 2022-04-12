using System;

namespace p9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que faça 5 perguntas para uma pessoa sobre um crime. As perguntas são:
            - Telefonou para a vítima?
            - Esteve no loval do crime?
            - Mora perto da vítima?
            - Devia para vítima?
            - Trabalhou para a vítima?
            O programa deve, no final, emitir uma classificação sobre a participação da pessoa no crime. Se a pessoa responder positivamente a 2 questões
            ela deve ser classificada como "Suspeita", entre 3 e 4 como "Cúmplice" e 5 como "Assassino". Caso contrário, ele será classificado como 
            "Inocente".*/
 
        Console.Write("\nInterrogatório\n\n\tTelefonou para a vítima (S/N)? ");
        string res1 = Console.ReadLine().ToUpper();
        char resposta1 = Convert.ToChar(res1);
 
        int respostassim = 0;
        if (resposta1 == 'S') {
            respostassim++;
        }
 
        Console.Write("\n\tEsteve no local do crime (S/N)? ");
        string res2 = Console.ReadLine().ToUpper();
        char resposta2 = Convert.ToChar(res2);
 
        if (resposta2 == 'S') {
            respostassim++;
        }
 
        Console.Write("\n\tMora perto da vítima (S/N)? ");
        string res3 = Console.ReadLine().ToUpper();
        char resposta3 = Convert.ToChar(res3);
 
        if (resposta3 == 'S') {
            respostassim++;
        }
 
        Console.Write("\n\tDevia para a vítima (S/N)? ");
        string res4 = Console.ReadLine().ToUpper();
        char resposta4 = Convert.ToChar(res4);
 
        if (resposta4 == 'S') {
            respostassim++;
        }
 
        Console.Write("\n\tTrabalhou para a vítima (S/N)? ");
        string res5 = Console.ReadLine().ToUpper();
        char resposta5 = Convert.ToChar(res5);
 
        if (resposta5 == 'S') {
            respostassim++;
        }
 
        if (respostassim==2) {
            Console.Write("\n\nSuspeito.\n\n");
        } else if ((respostassim==3)|(respostassim==4)) {
            Console.Write("\n\nCúmplice.\n\n");
        } else if (respostassim==5) {
            Console.Write("\n\nCulpado.\n\n");
        } else {
            Console.Write("\n\nInocente.\n\n");
        }

        }
    }
}
