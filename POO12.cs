using System;

namespace TrianguloRetangulo
{
    public class Triangulo
    {
        public double LadoA { get; set; }
        public double LadoB { get; set; }
        public double LadoC { get; set; }

        public Triangulo(double ladoA, double ladoB, double ladoC)
        {
            LadoA = ladoA;
            LadoB = ladoB;
            LadoC = ladoC;
        }

        public bool EhTriangulo()
        {
            return LadoA + LadoB > LadoC &&
                   LadoA + LadoC > LadoB &&
                   LadoB + LadoC > LadoA;
        }

        public bool EhRetangulo()
        {
            if (!EhTriangulo())
                return false;

            double[] lados = { LadoA, LadoB, LadoC };
            Array.Sort(lados);

            double cateto1 = lados[0];
            double cateto2 = lados[1];
            double hipotenusa = lados[2];

            return Math.Abs(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2) - Math.Pow(hipotenusa, 2)) < 1e-6;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Digite os três lados do triângulo:");
                Console.Write("Lado A: ");
                double ladoA = Convert.ToDouble(Console.ReadLine());
                Console.Write("Lado B: ");
                double ladoB = Convert.ToDouble(Console.ReadLine());
                Console.Write("Lado C: ");
                double ladoC = Convert.ToDouble(Console.ReadLine());

                Triangulo triangulo = new Triangulo(ladoA, ladoB, ladoC);

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
            catch (FormatException)
            {
                Console.WriteLine("Por favor, insira valores numéricos válidos.");
            }
        }
    }
}
