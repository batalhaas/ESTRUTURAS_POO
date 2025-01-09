private void btnCalcular_Click(object sender, EventArgs e)
{
    try
    {
        // Obtém os valores dos lados a partir dos TextBoxes
        double ladoA = Convert.ToDouble(txtLadoA.Text);
        double ladoB = Convert.ToDouble(txtLadoB.Text);
        double ladoC = Convert.ToDouble(txtLadoC.Text);

        // Cria uma instância da classe Triangulo
        Triangulo triangulo = new Triangulo(ladoA, ladoB, ladoC);

        // Verifica e exibe o resultado
        if (triangulo.EhTriangulo())
        {
            if (triangulo.EhRetangulo())
            {
                lblResultado.Text = "Os valores formam um triângulo retângulo.";
            }
            else
            {
                lblResultado.Text = "Os valores formam um triângulo, mas não é retângulo.";
            }
        }
        else
        {
            lblResultado.Text = "Os valores não formam um triângulo.";
        }
    }
    catch (FormatException)
    {
        lblResultado.Text = "Por favor, insira valores numéricos válidos.";
    }
    catch (Exception ex)
    {
        lblResultado.Text = $"Erro inesperado: {ex.Message}";
    }
}
