using System;

namespace PesoIdeal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o peso da pessoa (em kg): ");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura da pessoa (em metros): ");
            double altura = double.Parse(Console.ReadLine());

            Pessoa pessoa = new Pessoa(peso, altura);

            Console.WriteLine($"{pessoa.ObterMensagemPesoIdeal()}");
        }
    }

    class Pessoa
    {
        public double Peso { get; private set; }
        public double Altura { get; private set; }

        public Pessoa(double peso, double altura)
        {
            Peso = peso;
            Altura = altura;
        }

        public double CalcularRelacaoPesoAltura()
        {
            return Peso / (Altura * Altura);
        }

        public string ObterMensagemPesoIdeal()
        {
            double relacao = CalcularRelacaoPesoAltura();

            if (relacao < 20)
            {
                return $"Relação: {relacao:F2}. Você está abaixo do peso.";
            }
            else if (relacao >= 20 && relacao < 25)
            {
                return $"Relação: {relacao:F2}. Você está no peso ideal.";
            }
            else
            {
                return $"Relação: {relacao:F2}. Você está acima do peso.";
            }
        }
    }
}