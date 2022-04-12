using System;

namespace p21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que calcule as raízes de uma equação do segundo grau, na forma ax2 + bx + c.
            O programa deverá pedir os valores de a, b e c e fazer as consistências, informando ao usuário
            as seguintes situações:  

	        Se o usuário informar o valor de A igual a zero, a equação não é do segundo grau e o programa 
            não deve pedir os demais valores, sendo encerrado;
	        Se o delta calculado for negativo, a equação não possui raízes reais. Informe ao usuário e 
            encerre o programa;
	        Se o delta calculado for igual a zero, a equação possui apenas uma raiz real; informe ao usuário;
	        Se o delta for positivo, a equação possui duas raízes reais; informe-as ao usuário.*/

            Console.Write("\nResolução de equação de segundo grau\nATENÇÃO: A equação deve ser de segundo grau.\n\n\tModelo ax^2 + bx + c\n\n\tValor de 'a': ");
            string a = Console.ReadLine();
            double A = Convert.ToDouble(a);

            if (A==0) {
                Console.WriteLine("\nPrograma encerrado.\nCaso 'a' seja igual a zero, a equação não se configurará como equação de segundo grau.\n");
            } else {
                Console.Write("\n\tValor de b: ");
                string b = Console.ReadLine();
                double B = Convert.ToDouble(b);

                Console.Write("\n\tValor de c: ");
                string c = Console.ReadLine();
                double C = Convert.ToDouble(c);

                double delta = (B*B)-((4*A)*C);

                if (delta<0) {
                    Console.WriteLine("\nPara esta equação não há raiz real.\n");
                } else if (delta==0) {
                    double raiz = ((-B)/(2*A));
                    Console.WriteLine($"\nSó há uma raiz real para essa equação. \nRaiz: {raiz}\n");
                } else {
                    double raiz1 =(((-B)+(Math.Sqrt(delta)))/(2*A));
                    double raiz2 =(((-B)-(Math.Sqrt(delta)))/(2*A));
                    Console.WriteLine($"\nHá duas raizes reais para essa equação. \n\nPrimeira raiz: {raiz1}\nSegunda Raiz: {raiz2}\n");
                }
            }
        }
    }
}
