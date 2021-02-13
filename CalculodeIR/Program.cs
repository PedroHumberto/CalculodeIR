using System;

namespace CalculodeIR
{
    class Program
    {
        static void Main(string[] args)
        {

        beginin:

            double aluguel, comissao, baseDeCalculo;
            Console.Clear();
            Console.WriteLine("Digite o valor do aluguel:");
            Console.Write("R$");
            aluguel = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da comissão:");
            Console.Write("R$");
            comissao = double.Parse(Console.ReadLine());

            baseDeCalculo = aluguel - comissao;
            double quarta = 0.275;
            double terca = 0.225;
            double segunda = 0.150;
            double primeira = 0.075;

            
            double A = (quarta * baseDeCalculo) - 869.36;
            double B =(terca * baseDeCalculo) - 636.13;
            double C = (segunda * baseDeCalculo) - 354.80;
            double D = (primeira * baseDeCalculo) - 142.80;



            if (baseDeCalculo > 4664.67 && baseDeCalculo < 9999999999999999999)
                Console.WriteLine("O valor do imposto de renda é: R$" + A.ToString("F2"));

           if (baseDeCalculo > 3751.04 && baseDeCalculo < 4664.68)
                Console.WriteLine("O valor do imposto de renda é: R$" + B.ToString("F2"));

            if (baseDeCalculo > 2826.65 && baseDeCalculo < 3751.05)
                Console.WriteLine("O valor do imposto de renda é: R$" + C.ToString("F2"));

            if (baseDeCalculo > 1903.98 && baseDeCalculo < 2826.65)
                Console.WriteLine("O valor do imposto de renda é: R$" + D.ToString("F2"));

            if (baseDeCalculo < 1903.98)
                Console.WriteLine("Não tem IR");
            


            Console.ReadLine();
            goto beginin;

        }
    }
}
