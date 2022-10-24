using Calculadora.OperacoesBasicas;

namespace Calculadora.OperacoesCalculos
{
    class OperacaoCalculo
    {
        public Soma Soma{ get; private set; }
        public Subtracao Subtracao { get; private set; }
        public Multiplicacao Multiplicacao { get; private set; }
        public Divisao Divisao { get; private set; }

        public OperacaoCalculo()
        {
            Soma = new Soma();
            Subtracao = new Subtracao();
            Multiplicacao = new Multiplicacao();
            Divisao = new Divisao();
        }
    }
}
