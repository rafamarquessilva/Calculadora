namespace Calculadora.OperacoesBasicas
{
    public class Divisao: OperacaoBasicaAbstract
    {
        public override double Calcular(double dividendo, double divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }

            return dividendo / divisor;
        }
    }
}
