using System;

namespace Atividade_4.Classes
{
    public class InvestimentoSemIR : Investimento
    {
        public double calcularLucroSemIR(int meses)
        {
            if(valorInicial < 1000)
            {
                return 0;
            }
            else 
            {
                return (valorInicial * Math.Pow((1 + jurosMensais / 100), meses) - valorInicial);
            }
        }
    }
}