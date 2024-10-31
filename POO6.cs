using System;

namespace ConversaoDolarParaReal
{
    // Classe ConversorMoeda com propriedades e método para converter dólares em reais
    public class ConversorMoeda
    {
        // Propriedades para armazenar a cotação do dólar e a quantidade em dólares
        public double CotacaoDolar { get; set; }
        public double QuantidadeDolares { get; set; }

        // Construtor para inicializar a cotação e a quantidade de dólares
        public ConversorMoeda(double cotacaoDolar, double quantidadeDolares)
        {
            CotacaoDolar = cotacaoDolar;
            QuantidadeDolares = quantidadeDolares;
        }

        // Método para calcular o valor em reais
        public double ConverterParaReais()
        {
            return CotacaoDolar * QuantidadeDolares;
        }
    }

    // Classe principal
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada do usuário para a cotação do dólar
            Console.Write("Digite o valor da cotação do dólar: ");
            double cotacaoDolar = Convert.ToDouble(Console.ReadLine());

            // Entrada do usuário para a quantidade de dólares
            Console.Write("Digite a quantidade de dólares: ");
            double quantidadeDolares = Convert.ToDouble(Console.ReadLine());

            // Instância do objeto ConversorMoeda
            ConversorMoeda conversor = new ConversorMoeda(cotacaoDolar, quantidadeDolares);

            // Conversão e exibição do valor em reais
            double valorEmReais = conversor.ConverterParaReais();
            Console.WriteLine($"O valor correspondente em reais é: R$ {valorEmReais:F2}");
        }
    }
}
