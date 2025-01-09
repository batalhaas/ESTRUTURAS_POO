namespace VerificarTriangulo
{
    partial class FormTriangulo
    {
        private System.ComponentModel.IContainer components = null;

        // Limpeza de recursos usados.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Método necessário para o Designer de Suporte
        private void InitializeComponent()
        {
            this.labelLado1 = new System.Windows.Forms.Label();
            this.txtLado1 = new System.Windows.Forms.TextBox();
            this.labelLado2 = new System.Windows.Forms.Label();
            this.txtLado2 = new System.Windows.Forms.TextBox();
            this.labelLado3 = new System.Windows.Forms.Label();
            this.txtLado3 = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLado1
            // 
            this.labelLado1.AutoSize = true;
            this.labelLado1.Location = new System.Drawing.Point(20, 20);
            this.labelLado1.Name = "labelLado1";
            this.labelLado1.Size = new System.Drawing.Size(49, 15);
            this.labelLado1.TabIndex = 0;
            this.labelLado1.Text = "Lado 1:";
            // 
            // txtLado1
            // 
            this.txtLado1.Location = new System.Drawing.Point(100, 17);
            this.txtLado1.Name = "txtLado1";
            this.txtLado1.Size = new System.Drawing.Size(100, 23);
            this.txtLado1.TabIndex = 1;
            // 
            // labelLado2
            // 
            this.labelLado2.AutoSize = true;
            this.labelLado2.Location = new System.Drawing.Point(20, 60);
            this.labelLado2.Name = "labelLado2";
            this.labelLado2.Size = new System.Drawing.Size(49, 15);
            this.labelLado2.TabIndex = 2;
            this.labelLado2.Text = "Lado 2:";
            // 
            // txtLado2
            // 
            this.txtLado2.Location = new System.Drawing.Point(100, 57);
            this.txtLado2.Name = "txtLado2";
            this.txtLado2.Size = new System.Drawing.Size(100, 23);
            this.txtLado2.TabIndex = 3;
            // 
            // labelLado3
            // 
            this.labelLado3.AutoSize = true;
            this.labelLado3.Location = new System.Drawing.Point(20, 100);
            this.labelLado3.Name = "labelLado3";
            this.labelLado3.Size = new System.Drawing.Size(49, 15);
            this.labelLado3.TabIndex = 4;
            this.labelLado3.Text = "Lado 3:";
            // 
            // txtLado3
            // 
            this.txtLado3.Location = new System.Drawing.Point(100, 97);
            this.txtLado3.Name = "txtLado3";
            this.txtLado3.Size = new System.Drawing.Size(100, 23);
            this.txtLado3.TabIndex = 5;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(50, 140);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(120, 30);
            this.btnVerificar.TabIndex = 6;
            this.btnVerificar.Text = "Verificar Triângulo";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(20, 190);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(81, 19);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "Resultado:";
            // 
            // FormTriangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 250);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtLado3);
            this.Controls.Add(this.labelLado3);
            this.Controls.Add(this.txtLado2);
            this.Controls.Add(this.labelLado2);
            this.Controls.Add(this.txtLado1);
            this.Controls.Add(this.labelLado1);
            this.Name = "FormTriangulo";
            this.Text = "Verificar Triângulo";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelLado1;
        private System.Windows.Forms.TextBox txtLado1;
        private System.Windows.Forms.Label labelLado2;
        private System.Windows.Forms.TextBox txtLado2;
        private System.Windows.Forms.Label labelLado3;
        private System.Windows.Forms.TextBox txtLado3;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblResultado;
    }
}
