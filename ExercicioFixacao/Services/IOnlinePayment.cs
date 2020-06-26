using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixacao.Services
{
    interface PagamentoOnline
    {
        public double Juros(double valorParcela, int parcela);
        public double Taxa(double valor);
    }
}
