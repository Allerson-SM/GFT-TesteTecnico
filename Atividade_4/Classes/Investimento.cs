using System;

namespace Atividade_4.Classes
{

    public class Investimento
    {
        public double valorInicial { get; set; }

        public double jurosMensais { get; set; }

        public double calcularLucro(int meses)
        {
            return (valorInicial * Math.Pow((1 + jurosMensais / 100), meses) - valorInicial);
        }
    }

}