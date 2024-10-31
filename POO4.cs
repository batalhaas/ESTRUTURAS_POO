using System;

namespace CalculoAreaTriangulo
{
    // Classe Triangulo com propriedades e método para calcular a área
    public class Triangulo
    {
        // Propriedades para armazenar a base e altura do triângulo
        public double Base { get; set; }
        public double Altura { get; set; }

        // Construtor para inicializar base e altura
        public Triangulo(double baseTriangulo, double alturaTriangulo)
        {
            Base = baseTriangulo;
            Altura = alturaTriangulo;
        }

        // Método para calcular a área do triângulo
        public double CalcularArea()
        {
            return (Base * Altura) / 2;
        }
    }

    // Classe principal
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada do usuário
            Console.Write("Digite o valor da base do triângulo: ");
            double baseTriangulo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor da altura do triângulo: ");
            double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

            // Instância do objeto Triangulo
            Triangulo triangulo = new Triangulo(baseTriangulo, alturaTriangulo);

            // Cálculo e exibição da área
            double area = triangulo.CalcularArea();
            Console.WriteLine($"A área do triângulo é: {area}");
        }
    }
}
