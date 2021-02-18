using System;

namespace CalculodeIR
{
    class Program
    {
        static void Main(string[] args)
        {

        beginin:

            Console.Clear();


            //Declaração das variaveis
            double aluguel, comissao, baseDeCalculo;

            Console.WriteLine("Digite o valor do aluguel:");
            Console.Write("R$");
            aluguel = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da comissão:");
            Console.Write("R$");
            comissao = double.Parse(Console.ReadLine());


            //Base de calculo do imposto
            baseDeCalculo = aluguel - comissao;

            //Caluclo do imposto
            var imposto;

            if (baseDeCalculo > 4664.67)
            {
                imposto = (0.275 * baseDeCalculo) - 869.36;
            }

            else if (baseDeCalculo > 3751.04 && baseDeCalculo < 4664.68)
            {
                imposto = (0.225 * baseDeCalculo) - 636.13;
            }

            else if (baseDeCalculo > 2826.65 && baseDeCalculo < 3751.05)
            {
                imposto = (0.150 * baseDeCalculo) - 354.80;
            }

            else if (baseDeCalculo > 1903.98 && baseDeCalculo < 2826.65)
            {
                imposto = (0.075 * baseDeCalculo) - 142.80;
            }

            else if (baseDeCalculo < 1903.98)
            {
                Console.WriteLine("Não tem IR");
            }
            else
            {
                Console.WriteLine("O Valor do impsto de renda é R$" + imposto)
            }
            
            //Para dar o retorno apos preencher qualquer coisa.
            Console.ReadLine();
            goto beginin;

        }
    }
}
