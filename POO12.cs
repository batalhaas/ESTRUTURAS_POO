using System;

namespace TrianguloRetangulo
{
    // Classe para representar e verificar um triângulo
    public class Triangulo
    {
        // Propriedades dos lados do triângulo
        public double LadoA { get; set; }
        public double LadoB { get; set; }
        public double LadoC { get; set; }

        // Construtor
        public Triangulo(double ladoA, double ladoB, double ladoC)
        {
            LadoA = ladoA;
            LadoB = ladoB;
            LadoC = ladoC;
        }

        // Método para verificar se os valores formam um triângulo
        public bool EhTriangulo()
        {
            return LadoA + LadoB > LadoC &&
                   LadoA + LadoC > LadoB &&
                   LadoB + LadoC > LadoA;
        }

        // Método para verificar se é um triângulo retângulo
        public bool EhRetangulo()
        {
            if (!EhTriangulo())
            {
                return false;
            }

            // Ordenar os lados para identificar a hipotenusa
            double[] lados = { LadoA, LadoB, LadoC };
            Array.Sort(lados);

            double cateto1 = lados[0];
            double cateto2 = lados[1];
            double hipotenusa = lados[2];

            // Verificar o Teorema de Pitágoras
            return Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2) == Math.Pow(hipotenusa, 2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os três lados do triângulo:");

            // Lê os valores dos lados
            Console.Write("Lado A: ");
            double ladoA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Lado B: ");
            double ladoB = Convert.ToDouble(Console.ReadLine());

            Console.Write("Lado C: ");
            double ladoC = Convert.ToDouble(Console.ReadLine());

            // Instancia um objeto da classe Triangulo
            Triangulo triangulo = new Triangulo(ladoA, ladoB, ladoC);

            // Verifica e exibe o resultado
            if (triangulo.EhTriangulo())
            {
                if (triangulo.EhRetangulo())
                {
                    Console.WriteLine("Os valores formam um triângulo retângulo.");
                }
                else
                {
                    Console.WriteLine("Os valores formam um triângulo, mas não é retângulo.");
                }
            }
            else
            {
                Console.WriteLine("Os valores não formam um triângulo.");
            }
        }
    }
}
