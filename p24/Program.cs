using System;

namespace p24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa para o cálculo de uma folha de pagamento de uma empresa que paga
             por hora de trabalho. Os descontos do imposto de renda dependem do salário bruto 
             (conforme tabela abaixo). 

	        De 0,00 até 1.903,98 – isento;
	        De 1.903,99 até 2.826,65 – 7,5%;
	        De 2.826,66 até 3.751,05 – 15%;
	        De 3.751,06 até 4.664,68 – 22,5%;
	        A partir de 4.664,68 - 27,5%.

            Há também um desconto de 3% para o sindicato, independente da faixa salarial. Outra 
            informação importante é o valor do FGTS recolhido pela empresa, que corresponde a 11%
            do salário bruto e que não é descontado do funcionário (é a empresa que deposita). 
            O salário líquido corresponde ao salário bruto menos os descontos. O programa deverá
            pedir ao usuário o valor da sua hora, a quantidade de horas trabalhadas no mês e 
            realizar os cálculos. Por fim, o programa deverá mostrar uma saída semelhante à saída 
             a seguir:

            Horas trabalhadas: 		180
            Valor da hora: 			R$ 20,00
            Salário bruto (180 * 220):	R$ 3600,00
            ( – ) IR (15%): 		R$ 540,00
            ( – ) Sindicato (3%): 		R$ 108,00
            FGTS ( 11%): 			R$ 121,00
            Total de descontos: 		R$ 648,00
            Salário líquido:		R$ 2.952,00 */
            
            Console.Write("\nCalculadora de Salário\nVamos começar?\n\n\tInforme as horas trabalhadas: ");
            string hr = Console.ReadLine();
            double horas = Convert.ToDouble(hr);

            Console.Write("\n\tInforme o valor da hora: ");
            string vlr = Console.ReadLine();
            double valor = Convert.ToDouble(vlr);

            Console.WriteLine($"\nHoras trabalhadas: {horas}");
            Console.WriteLine($"Valor da hora: {valor}");

            double bruto = (valor*horas);
            Console.WriteLine($"Salário bruto: {bruto}");

            double ir= 0;
            if (bruto<=2826.65) {
                if (bruto<=1903.98) {
                    Console.WriteLine("( - ) IR (0%): Isento");
                } else {
                    ir = (bruto*(0.075));
                    Console.WriteLine($"( - ) IR (7,5%): {ir}");
                }
            } else {
                if (bruto <= 4664.68) {
                    if (bruto <= 3751.05) {
                        ir = (bruto*(0.15));
                        Console.WriteLine($"( - ) IR (15%): {ir}");
                    } else {
                        ir = (bruto*(0.225));
                        Console.WriteLine($"( - ) IR (22,5%): {ir}");
                    }
                } else {
                    ir = (bruto*(0.275));
                    Console.WriteLine($"( - ) IR (27,5%): {ir}");
                }
            }

            double sindicato = (bruto*0.03);
            double fgts = (bruto*0.11);
            double total = ((fgts+sindicato)+ir);
            double liquido = (bruto - total);

            Console.WriteLine($"( - ) Sindicato (3%): {sindicato}\n( - ) FGTS (11%): {fgts}\nTotal de desconto salarial: {total}\nSalário líquido: {liquido}\n");

        }
    }
}
