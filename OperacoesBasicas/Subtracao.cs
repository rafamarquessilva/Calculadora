﻿namespace Calculadora.OperacoesBasicas
{
    public class Subtracao: OperacaoBasicaAbstract
    {
        public override double Calcular(double valor1, double valor2)
        {
            return valor1 - valor2;
        }
    }
}
