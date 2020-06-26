using ExercicioFixacao.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace ExercicioFixacao.Services
{
    class ContractService
    {
        private PagamentoOnline _pagamentoOnline;

        public ContractService(PagamentoOnline pagamentoOnline)
        {
            _pagamentoOnline = pagamentoOnline;
        }

        public void ProcessarContrato(Entities.Contract contrato, int meses)
        {
            for (int i = 1; i <= meses; i++)
            {
                DateTime vencimento = contrato.Data.AddMonths(i);
                double valorParcela = contrato.ValorTotal / meses;
                valorParcela += _pagamentoOnline.Juros(valorParcela, i);
                valorParcela += _pagamentoOnline.Taxa(valorParcela);

                contrato.Parcelas.Add(new Parcela(vencimento, valorParcela));
            }

        }
    }
}
