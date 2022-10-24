namespace Calculadora.OperacoesBasicas
{
    public class Multiplicacao : OperacaoBasicaAbstract
    {
        public override double Calcular(double multiplicando, double multiplicador)
        {
            return multiplicando * multiplicador;
        }
    }
}
