using System;

namespace Atividade_1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Quantidade de números pares");
            System.Console.WriteLine("Digite um número abaixo entre 1000 e 9999");
            Numeros();

        }
        public static void Numeros()
        {
            var numero = Int32.Parse(Console.ReadLine());

            if (numero < 1000 || numero > 9999)
            {
                System.Console.WriteLine("Número inválido, favor digitar um número entre 1000 e 9999");
            }
            string sNumero = numero.ToString();

            double n1 = Double.Parse(sNumero.Substring(0, 1));
            double n2 = Double.Parse(sNumero.Substring(1, 1));
            double n3 = Double.Parse(sNumero.Substring(2, 1));
            double n4 = Double.Parse(sNumero.Substring(3, 1));

            var contador = 0;

            if (n1 % 2 == 0)
            {
                contador += 1;
            }
            if (n2 % 2 == 0)
            {
                contador += 1;
            }
            if (n3 % 2 == 0)
            {
                contador += 1;
            }
            if (n4 % 2 == 0)
            {
                contador += 1;
            }

            System.Console.WriteLine(contador);
        }
    }
}
