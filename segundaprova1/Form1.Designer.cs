namespace segundaprova1
{
    partial class Servico
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.sv_servico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sv_servico
            // 
            this.sv_servico.Location = new System.Drawing.Point(315, 102);
            this.sv_servico.Name = "sv_servico";
            this.sv_servico.Size = new System.Drawing.Size(75, 23);
            this.sv_servico.TabIndex = 0;
            this.sv_servico.Text = "Servico";
            this.sv_servico.UseVisualStyleBackColor = true;
            this.sv_servico.Click += new System.EventHandler(this.button1_Click);
            // 
            // Servico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sv_servico);
            this.Name = "Servico";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sv_servico;
    }
}

