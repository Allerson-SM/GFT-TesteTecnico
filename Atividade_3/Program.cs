using System;

namespace Atividade_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a data do seu aniversário - 2020");
            System.Console.WriteLine("Informe o dia do seu aniversário");
            var dia = Int32.Parse(Console.ReadLine());

            System.Console.WriteLine("Informe o mês do seu aniversário");
            var mes = Int32.Parse(Console.ReadLine());

            // System.Console.WriteLine("Informe o ano do seu aniversário");
            // var ano = Console.ReadLine();
            
            var date1 = new DateTime(2020, mes, dia);
            Console.WriteLine(date1);
        }
    }
}
