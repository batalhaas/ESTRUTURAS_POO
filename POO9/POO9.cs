using System;

namespace CalculoAreaRetangulo
{
    // Classe Retangulo com propriedades e método para calcular a área
    public class Retangulo
    {
        // Propriedades da base e da altura do retângulo
        public double Base { get; set; }
        public double Altura { get; set; }

        // Construtor para inicializar base e altura
        public Retangulo(double baseRetangulo, double alturaRetangulo)
        {
            Base = baseRetangulo;
            Altura = alturaRetangulo;
        }

        // Método para calcular a área e retornar o tipo de terreno
        public string AvaliarTerreno()
        {
            double area = Base * Altura;
            if (area > 100)
            {
                return $"A área do terreno é {area}. Terreno grande.";
            }
            else
            {
                return $"A área do terreno é {area}. Terreno pequeno.";
            }
        }
    }

    // Classe principal
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada do usuário para base e altura
            Console.Write("Digite o valor da base do retângulo: ");
            double baseRetangulo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor da altura do retângulo: ");
            double alturaRetangulo = Convert.ToDouble(Console.ReadLine());

            // Instância do objeto Retangulo
            Retangulo retangulo = new Retangulo(baseRetangulo, alturaRetangulo);

            // Avaliação do terreno e exibição do resultado
            string resultado = retangulo.AvaliarTerreno();
            Console.WriteLine(resultado);
        }
    }
}
