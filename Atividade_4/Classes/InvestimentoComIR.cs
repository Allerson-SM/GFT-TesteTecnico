using System;

namespace Atividade_4.Classes
{
    public class InvestimentoComIR : Investimento
    {
        public double calcularLucroIR(int meses)
        {
            if (meses < 6)
            {
                var desconto = calcularLucro(meses) / 100 * 22.5;
                return calcularLucro(meses) - desconto;
            }
            else if (meses >= 6 && meses < 12)
            {
                var desconto = calcularLucro(meses) / 100 * 20;
                return calcularLucro(meses) - desconto;
            }
            else if (meses >= 12 && meses < 24)
            {
                var desconto = calcularLucro(meses) / 100 * 17.5;
                return calcularLucro(meses) - desconto;
            }
            else
            {
                var desconto =  calcularLucro(meses) / 100 * 15;
                return calcularLucro(meses) - desconto;
            }
            
        }
    }
}