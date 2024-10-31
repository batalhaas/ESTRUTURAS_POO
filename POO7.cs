using System;

namespace ComparadorValores
{
    // Classe Comparador com método para comparar dois valores
    public class Comparador
    {
        // Método para retornar o maior entre dois valores
        public double ObterMaior(double valor1, double valor2)
        {
            return valor1 > valor2 ? valor1 : valor2;
        }
    }

    // Classe principal
    class Program
    {
        static void Main(string[] args)
        {
            // Entradas do usuário
            Console.Write("Digite o primeiro valor: ");
            double valor1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            double valor2 = Convert.ToDouble(Console.ReadLine());

            // Instância do objeto Comparador
            Comparador comparador = new Comparador();

            // Comparação e exibição do maior valor
            double maiorValor = comparador.ObterMaior(valor1, valor2);
            Console.WriteLine($"O maior valor é: {maiorValor}");
        }
    }
}
