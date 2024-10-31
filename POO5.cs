using System;

namespace ConversaoMilhasMaritimas
{
    // Classe Conversor com método para converter milhas marítimas em quilômetros
    public class Conversor
    {
        // Método para converter milhas marítimas em quilômetros
        public double ConverterMilhasParaQuilometros(double milhasMaritimas)
        {
            double metros = milhasMaritimas * 1852;    // Converte milhas para metros
            double quilometros = metros / 1000;        // Converte metros para quilômetros
            return quilometros;
        }
    }

    // Classe principal
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada do usuário
            Console.Write("Digite o valor em milhas marítimas: ");
            double milhasMaritimas = Convert.ToDouble(Console.ReadLine());

            // Instância do objeto Conversor
            Conversor conversor = new Conversor();

            // Conversão e exibição do resultado
            double quilometros = conversor.ConverterMilhasParaQuilometros(milhasMaritimas);
            Console.WriteLine($"{milhasMaritimas} milhas marítimas equivalem a {quilometros} quilômetros.");
        }
    }
}
