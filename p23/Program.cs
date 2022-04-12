using System;

namespace p23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*As Organizações Tabajara resolveram dar um aumento de salário aos seus colaboradores e 
            lhe contrataram para desenvolver o programa que calculará os reajustes. Faça um programa 
            recebe o salário de um colaborador e reajuste esse salário segundo o seguinte critério, 
            baseado no salário atual:

	        Salários até R$ 280,00 (incluindo): aumento de 20%;
	        Salários entre R$ 280,00 e R$700,00: aumento de 15%;
	        Salários entre R$ 700,00 e R$ 1500,00: aumento de 10%;
	        Salários de R$ 1500,00 em diante: aumento de 5%.

	        Após o aumento ser realizado, informe na tela:

	        a. O salário antes do reajuste;
	        b. O percentual de aumento aplicado;
	        c. O valor do aumento;
	        d. O novo salário (após o aumento).
            */
            
            Console.Write("\nReajuste Salárial\n\n\tSalário atual do colaborador: ");
            string sa = Console.ReadLine();
            double salario = Convert.ToDouble(sa);

            double aumento = 0;
            double nsalario = 0;
            Console.WriteLine($"\nSalário (antes): {salario}");
            if (salario<700) {
                if (salario<280) {
                    aumento = (salario*0.2);
                    nsalario = (salario + aumento);
                    Console.WriteLine($"Percentual de aumento: 20%\nValor do aumento {(aumento)}\nNovo salário: {(nsalario)}\n");
                } else {
                    aumento = (salario*0.15);
                    nsalario = (salario + aumento);
                    Console.WriteLine($"Percentual de aumento: 15%\nValor do aumento {(aumento)}\nNovo salário: {(nsalario)}\n");
                }
            } else {
                if (salario<1500) {
                    aumento = (salario*0.1);
                    nsalario = (salario + aumento);
                    Console.WriteLine($"Percentual de aumento: 10%\nValor do aumento {(aumento)}\nNovo salário: {(nsalario)}\n");
                } else {
                    aumento = (salario*0.05);
                    nsalario = (salario + aumento);
                    Console.WriteLine($"Percentual de aumento: 5%\nValor do aumento {(aumento)}\nNovo salário: {(nsalario)}\n");
                }
            }
        }
    }
}
