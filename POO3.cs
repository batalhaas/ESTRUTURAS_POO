using System;

namespace CalculoAreaQuadrado
{
    // Classe Quadrado com propriedade e método para calcular a área
    public class Quadrado
    {
        // Propriedade para armazenar o valor da diagonal
        public double Diagonal { get; set; }

        // Construtor para inicializar a diagonal
        public Quadrado(double diagonal)
        {
            Diagonal = diagonal;
        }

        // Método para calcular a área do quadrado
        public double CalcularArea()
        {
            return (Diagonal * Diagonal) / 2;
        }
    }

    // Classe principal
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada do usuário
            Console.Write("Digite o valor da diagonal do quadrado: ");
            double diagonal = Convert.ToDouble(Console.ReadLine());

            // Instância do objeto Quadrado
            Quadrado quadrado = new Quadrado(diagonal);

            // Cálculo e exibição da área
            double area = quadrado.CalcularArea();
            Console.WriteLine($"A área do quadrado é: {area}");
        }
    }
}
