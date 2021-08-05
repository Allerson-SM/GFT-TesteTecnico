using System;
using Atividade_2.Classes;

namespace Atividade_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hotel - GFT");
            System.Console.WriteLine("Hospedagem convencional:");

            Hospedagem hospedagem = new Hospedagem();
            var valor1 = hospedagem.Valor = 150;
            Console.WriteLine($"R${hospedagem.printValor()}");

            Console.WriteLine();
            System.Console.WriteLine("Hospedagem VIP:");

            HospedagemVIP hospedagemVIP = new HospedagemVIP();
            hospedagemVIP.Valor = valor1;
            var adicional = hospedagemVIP.ValorAdicional = 100;
            System.Console.WriteLine($"Adicional de R${adicional}");
            Console.WriteLine($"R${hospedagemVIP.printValorVip()}");

            System.Console.WriteLine();

        }
    }
}
