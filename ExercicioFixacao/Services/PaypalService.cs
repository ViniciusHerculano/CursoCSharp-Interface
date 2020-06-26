namespace ExercicioFixacao.Services
{

    class PaypalService : PagamentoOnline
    {
        private const double _taxa = 2 / 100.00; //2%
        private const double _juros = 1 / 100.00; //1%
        public double Juros(double valorParcela, int parcela)
        {
            return valorParcela * _juros * parcela;
        }

        public double Taxa(double valor)
        {
            return valor * _taxa;
        }
    }
}
