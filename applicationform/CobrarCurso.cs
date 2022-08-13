using System;
namespace applicationform
{
    public class CobrarCurso
    {
        public decimal ValorCurso { get; private set; } // private so esta sendo usada aqui
        public decimal ValorDesconto { get; private set; }
        public decimal ValorMulta { get; private set; }


        public decimal Resultado { get; set; }

        public CobrarCurso(decimal valorCurso, decimal valorMulta, decimal valorDesconto)
        {
            ValorCurso = valorCurso;
            ValorDesconto = valorDesconto;
            ValorMulta = valorMulta;

            Resultado = Calcular(valorCurso, valorDesconto, valorMulta);
        }

        public decimal Calcular(decimal valorCurso, decimal valorDesconto, decimal valorMulta)
        {
            if (valorMulta > 0)
                return valorCurso + valorMulta;
            else
                return valorCurso - valorDesconto;
        }

    }
}

