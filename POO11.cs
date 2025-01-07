using System;

namespace VerificarTriangulo
{
    // Classe para representar um triângulo
    public class Triangulo
    {
        // Propriedades para os lados do triângulo
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }
        public double Lado3 { get; set; }

        // Construtor
        public Triangulo(double lado1, double lado2, double lado3)
        {
            Lado1 = lado1;
            Lado2 = lado2;
            Lado3 = lado3;
        }

        // Método para verificar se os lados formam um triângulo
        public bool EhTriangulo()
        {
            return Lado1 + Lado2 > Lado3 &&
                   Lado1 + Lado3 > Lado2 &&
                   Lado2 + Lado3 > Lado1;
        }

        // Método para classificar o triângulo
        public string Classificar()
        {
            if (!EhTriangulo())
            {
                return "Os valores não formam um triângulo.";
            }

            if (Lado1 == Lado2 && Lado2 == Lado3)
            {
                return "Triângulo Equilátero";
            }
            else if (Lado1 == Lado2 || Lado1 == Lado3 || Lado2 == Lado3)
            {
                return "Triângulo Isósceles";
            }
            else
            {
                return "Triângulo Escaleno";
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os três lados do triângulo:");

            // Lê os valores dos lados
            Console.Write("Lado 1: ");
            double lado1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Lado 2: ");
            double lado2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Lado 3: ");
            double lado3 = Convert.ToDouble(Console.ReadLine());

            // Instancia um objeto da classe Triangulo
            Triangulo triangulo = new Triangulo(lado1, lado2, lado3);

            // Verifica e exibe o resultado
            string resultado = triangulo.Classificar();
            Console.WriteLine(resultado);
        }
    }
}
