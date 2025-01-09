private void btnCalcular_Click(object sender, EventArgs e)
{
    try
    {
        // Obtém os valores da base e altura dos campos de texto
        double baseRetangulo = Convert.ToDouble(txtBase.Text);
        double alturaRetangulo = Convert.ToDouble(txtAltura.Text);

        // Instancia a classe Retangulo
        Retangulo retangulo = new Retangulo(baseRetangulo, alturaRetangulo);

        // Avalia o terreno e exibe o resultado
        string resultado = retangulo.AvaliarTerreno();
        lblResultado.Text = resultado;
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
