private void btnVerificar_Click(object sender, EventArgs e)
{
    try
    {
        // Obter os valores dos lados
        double lado1 = Convert.ToDouble(txtLado1.Text);
        double lado2 = Convert.ToDouble(txtLado2.Text);
        double lado3 = Convert.ToDouble(txtLado3.Text);

        // Instanciar o objeto Triangulo
        Triangulo triangulo = new Triangulo(lado1, lado2, lado3);

        // Classificar o triângulo e exibir o resultado
        string resultado = triangulo.Classificar();
        lblResultado.Text = $"Resultado: {resultado}";
    }
    catch (FormatException)
    {
        MessageBox.Show("Por favor, insira valores numéricos válidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
