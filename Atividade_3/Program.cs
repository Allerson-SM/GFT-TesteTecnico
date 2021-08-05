using System;

namespace Atividade_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("aniversário");
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("Informe o dia do seu aniversário");
            var dia = Int32.Parse(Console.ReadLine());

            System.Console.WriteLine("Informe o mês do seu aniversário");
            var mes = Int32.Parse(Console.ReadLine());

            System.Console.WriteLine("Informe o ano do seu aniversário");
            var ano = Int32.Parse(Console.ReadLine());

            if (dia > 0 && dia <= 31 && mes > 0 && mes <= 12 && ano == 2020)
            {
                System.Console.WriteLine("Data válida");
            }
            else
            {
                System.Console.WriteLine("Data inválida");
            }
        }
    }
}
