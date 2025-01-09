using System;
using System.Windows.Forms;

namespace PesoIdeal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Obter os valores de peso e altura
                double peso = Convert.ToDouble(txtPeso.Text);
                double altura = Convert.ToDouble(txtAltura.Text);

                // Criar instância da classe Pessoa
                Pessoa pessoa = new Pessoa(peso, altura);

                // Obter a mensagem de peso ideal e exibir no label
                string mensagem = pessoa.ObterMensagemPesoIdeal();
                lblResultado.Text = mensagem;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    // Classe Pessoa
    public class Pessoa
    {
        public double Peso { get; private set; }
        public double Altura { get; private set; }

        public Pessoa(double peso, double altura)
        {
            Peso = peso;
            Altura = altura;
        }

        public double CalcularRelacaoPesoAltura()
        {
            return Peso / (Altura * Altura);
        }

        public string ObterMensagemPesoIdeal()
        {
            double relacao = CalcularRelacaoPesoAltura();

            if (relacao < 20)
            {
                return $"Relação: {relacao:F2}. Você está abaixo do peso.";
            }
            else if (relacao >= 20 && relacao < 25)
            {
                return $"Relação: {relacao:F2}. Você está no peso ideal.";
            }
            else
            {
                return $"Relação: {relacao:F2}. Você está acima do peso.";
            }
        }
    }
}
