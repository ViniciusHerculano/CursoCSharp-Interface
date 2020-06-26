using ExercicioFixacao.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixacao.Entities
{
    class Contract
    {
        public int Numero { get; set; }
        public DateTime Data { get; set; }
        public double ValorTotal { get; set; }

        public List<Parcela> Parcelas { get; set; }

        public Contract(int numero, DateTime data, double valorTotal)
        {
            Numero = numero;
            Data = data;
            ValorTotal = valorTotal;
            Parcelas = new List<Parcela>();
        }
    }
}
