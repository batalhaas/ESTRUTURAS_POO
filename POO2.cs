using System;

namespace CalculoAreaQuadrado
{
    // Classe Quadrado com propriedade e método para calcular a área
    public class Quadrado
    {
        // Propriedade para armazenar o valor da aresta
        public double Aresta { get; set; }

        // Construtor para inicializar a aresta
        public Quadrado(double aresta)
        {
            Aresta = aresta;
        }

        // Método para calcular a área do quadrado
        public double CalcularArea()
        {
            return Aresta * Aresta;
        }
    }

    // Classe principal
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada do usuário
            Console.Write("Digite o valor da aresta do quadrado: ");
            double aresta = Convert.ToDouble(Console.ReadLine());

            // Instância do objeto Quadrado
            Quadrado quadrado = new Quadrado(aresta);

            // Cálculo e exibição da área
            double area = quadrado.CalcularArea();
            Console.WriteLine($"A área do quadrado é: {area}");
        }
    }
}
