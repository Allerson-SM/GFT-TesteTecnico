using System;
using Atividade_4.Classes;

namespace Atividade_4
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Investimento");
            Investimento investimento = new Investimento();
            investimento.valorInicial = 1000;
            investimento.jurosMensais = 4;
            Console.WriteLine(investimento.calcularLucro(2));
            System.Console.WriteLine();

            System.Console.WriteLine("Investimento com IR");
            InvestimentoComIR investimentoComIR = new InvestimentoComIR();
            investimentoComIR.valorInicial = 4000;
            investimentoComIR.jurosMensais = 1.2;
            System.Console.WriteLine(investimentoComIR.calcularLucroIR(17));
            System.Console.WriteLine();

            System.Console.WriteLine("Investimento sem IR");
            InvestimentoSemIR investimentoSemIR = new InvestimentoSemIR();
            investimentoSemIR.valorInicial = 2000;
            investimentoSemIR.jurosMensais = 0.7;
            System.Console.WriteLine(investimentoSemIR.calcularLucroSemIR(10));

        }
    }
}
