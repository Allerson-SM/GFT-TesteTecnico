namespace Atividade_2.Classes
{
    public class HospedagemVIP : Hospedagem
    {
        public decimal ValorAdicional {get; set;}

        public decimal printValorVip()
        {
            return this.Valor + ValorAdicional;
        }
    }
}