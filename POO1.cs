using System;

namespace CalculoAreaRetangulo
{
    // Classe Retangulo com propriedades e método para calcular a área
    public class Retangulo
    {
        // Propriedades da Base e da Altura
        public double Base { get; set; }
        public double Altura { get; set; }

        // Construtor para inicializar Base e Altura
        public Retangulo(double baseRetangulo, double alturaRetangulo)
        {
            Base = baseRetangulo;
            Altura = alturaRetangulo;
        }

        // Método para calcular a área do retângulo
        public double CalcularArea()
        {
            return Base * Altura;
        }
    }

    // Classe principal
    class Program
    {
        static void Main(string[] args)
        {
            // Entradas do usuário
            Console.Write("Digite a base do retângulo: ");
            double baseRetangulo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a altura do retângulo: ");
            double alturaRetangulo = Convert.ToDouble(Console.ReadLine());

            // Instância do objeto Retangulo
            Retangulo retangulo = new Retangulo(baseRetangulo, alturaRetangulo);

            // Cálculo e exibição da área
            double area = retangulo.CalcularArea();
            Console.WriteLine($"A área do retângulo é: {area}");
        }
    }
}