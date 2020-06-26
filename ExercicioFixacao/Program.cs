using ExercicioFixacao.Entities;
using ExercicioFixacao.Services;
using System;
using System.Globalization;

namespace ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do contrato:");
            Console.Write("Numero: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Data(dd/mm/yyyy): ");
            DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Valor do contrato: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Numero de parcelas: ");
            int numeroParcelas = int.Parse(Console.ReadLine());

            Contract c = new Contract(numero, data, valor);
            ContractService servicoContrato = new ContractService(new PaypalService());
            servicoContrato.ProcessarContrato(c, numeroParcelas);

            Console.WriteLine("\nParcelas:");
            foreach (var parcela in c.Parcelas)
            {
                Console.WriteLine(parcela);
            }

        }
    }
}
