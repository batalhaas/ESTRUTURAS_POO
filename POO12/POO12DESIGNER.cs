namespace TrianguloRetangulo
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblLadoA;
        private System.Windows.Forms.TextBox txtLadoA;
        private System.Windows.Forms.Label lblLadoB;
        private System.Windows.Forms.TextBox txtLadoB;
        private System.Windows.Forms.Label lblLadoC;
        private System.Windows.Forms.TextBox txtLadoC;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblLadoA = new System.Windows.Forms.Label();
            this.txtLadoA = new System.Windows.Forms.TextBox();
            this.lblLadoB = new System.Windows.Forms.Label();
            this.txtLadoB = new System.Windows.Forms.TextBox();
            this.lblLadoC = new System.Windows.Forms.Label();
            this.txtLadoC = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // Label Lado A
            this.lblLadoA.AutoSize = true;
            this.lblLadoA.Location = new System.Drawing.Point(12, 15);
            this.lblLadoA.Name = "lblLadoA";
            this.lblLadoA.Size = new System.Drawing.Size(45, 13);
            this.lblLadoA.Text = "Lado A:";

            // TextBox Lado A
            this.txtLadoA.Location = new System.Drawing.Point(70, 12);
            this.txtLadoA.Name = "txtLadoA";
            this.txtLadoA.Size = new System.Drawing.Size(100, 20);

            // Label Lado B
            this.lblLadoB.AutoSize = true;
            this.lblLadoB.Location = new System.Drawing.Point(12, 45);
            this.lblLadoB.Name = "lblLadoB";
            this.lblLadoB.Size = new System.Drawing.Size(45, 13);
            this.lblLadoB.Text = "Lado B:";

            // TextBox Lado B
            this.txtLadoB.Location = new System.Drawing.Point(70, 42);
            this.txtLadoB.Name = "txtLadoB";
            this.txtLadoB.Size = new System.Drawing.Size(100, 20);

            // Label Lado C
            this.lblLadoC.AutoSize = true;
            this.lblLadoC.Location = new System.Drawing.Point(12, 75);
            this.lblLadoC.Name = "lblLadoC";
            this.lblLadoC.Size = new System.Drawing.Size(45, 13);
            this.lblLadoC.Text = "Lado C:";

            // TextBox Lado C
            this.txtLadoC.Location = new System.Drawing.Point(70, 72);
            this.txtLadoC.Name = "txtLadoC";
            this.txtLadoC.Size = new System.Drawing.Size(100, 20);

            // Button Calcular
            this.btnCalcular.Location = new System.Drawing.Point(15, 110);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(155, 23);
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // Label Resultado
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 150);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(58, 13);
            this.lblResultado.Text = "Resultado:";

            // Form1
            this.ClientSize = new System.Drawing.Size(284, 191);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtLadoC);
            this.Controls.Add(this.lblLadoC);
            this.Controls.Add(this.txtLadoB);
            this.Controls.Add(this.lblLadoB);
            this.Controls.Add(this.txtLadoA);
            this.Controls.Add(this.lblLadoA);
            this.Name = "Form1";
            this.Text = "Verificar Triângulo";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
