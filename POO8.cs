using System;

namespace ComparadorValores
{
    // Classe Comparador com método para comparar dois valores
    public class Comparador
    {
        // Método para retornar o maior entre dois valores ou indicar se são iguais
        public string ObterMaior(double valor1, double valor2)
        {
            if (valor1 > valor2)
            {
                return $"O maior valor é: {valor1}";
            }
            else if (valor2 > valor1)
            {
                return $"O maior valor é: {valor2}";
            }
            else
            {
                return "Os números são idênticos.";
            }
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

            // Comparação e exibição do resultado
            string resultado = comparador.ObterMaior(valor1, valor2);
            Console.WriteLine(resultado);
        }
    }
}
