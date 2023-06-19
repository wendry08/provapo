namespace segundaprova1
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_computador = new System.Windows.Forms.Label();
            this.lb_cliente = new System.Windows.Forms.Label();
            this.lb_servico = new System.Windows.Forms.Label();
            this.lb_tipopg = new System.Windows.Forms.Label();
            this.tx_comp = new System.Windows.Forms.TextBox();
            this.combo_serv = new System.Windows.Forms.ComboBox();
            this.combo_pg = new System.Windows.Forms.ComboBox();
            this.tx_clie = new System.Windows.Forms.TextBox();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_computador
            // 
            this.lb_computador.AutoSize = true;
            this.lb_computador.Location = new System.Drawing.Point(25, 52);
            this.lb_computador.Name = "lb_computador";
            this.lb_computador.Size = new System.Drawing.Size(67, 13);
            this.lb_computador.TabIndex = 0;
            this.lb_computador.Text = "Computador:";
            // 
            // lb_cliente
            // 
            this.lb_cliente.AutoSize = true;
            this.lb_cliente.Location = new System.Drawing.Point(29, 107);
            this.lb_cliente.Name = "lb_cliente";
            this.lb_cliente.Size = new System.Drawing.Size(42, 13);
            this.lb_cliente.TabIndex = 1;
            this.lb_cliente.Text = "Cliente:";
            // 
            // lb_servico
            // 
            this.lb_servico.AutoSize = true;
            this.lb_servico.Location = new System.Drawing.Point(29, 170);
            this.lb_servico.Name = "lb_servico";
            this.lb_servico.Size = new System.Drawing.Size(46, 13);
            this.lb_servico.TabIndex = 2;
            this.lb_servico.Text = "Servico:";
            // 
            // lb_tipopg
            // 
            this.lb_tipopg.AutoSize = true;
            this.lb_tipopg.Location = new System.Drawing.Point(25, 236);
            this.lb_tipopg.Name = "lb_tipopg";
            this.lb_tipopg.Size = new System.Drawing.Size(98, 13);
            this.lb_tipopg.TabIndex = 3;
            this.lb_tipopg.Text = "tipo de pagamento:";
            // 
            // tx_comp
            // 
            this.tx_comp.Location = new System.Drawing.Point(98, 52);
            this.tx_comp.Name = "tx_comp";
            this.tx_comp.Size = new System.Drawing.Size(100, 20);
            this.tx_comp.TabIndex = 4;
            this.tx_comp.TextChanged += new System.EventHandler(this.tx_comp_TextChanged);
            // 
            // combo_serv
            // 
            this.combo_serv.FormattingEnabled = true;
            this.combo_serv.Items.AddRange(new object[] {
            "Formatacao - 100$",
            "Limpeza - 50$",
            "Troca de peça - 200$"});
            this.combo_serv.Location = new System.Drawing.Point(98, 162);
            this.combo_serv.Name = "combo_serv";
            this.combo_serv.Size = new System.Drawing.Size(121, 21);
            this.combo_serv.TabIndex = 5;
            this.combo_serv.SelectedIndexChanged += new System.EventHandler(this.combo_serv_SelectedIndexChanged);
            // 
            // combo_pg
            // 
            this.combo_pg.FormattingEnabled = true;
            this.combo_pg.Items.AddRange(new object[] {
            "Dinheiro - 20%",
            "pix - 10%",
            "cartão - 0%"});
            this.combo_pg.Location = new System.Drawing.Point(146, 236);
            this.combo_pg.Name = "combo_pg";
            this.combo_pg.Size = new System.Drawing.Size(121, 21);
            this.combo_pg.TabIndex = 6;
            this.combo_pg.SelectedIndexChanged += new System.EventHandler(this.combo_pg_SelectedIndexChanged);
            // 
            // tx_clie
            // 
            this.tx_clie.Location = new System.Drawing.Point(77, 107);
            this.tx_clie.Name = "tx_clie";
            this.tx_clie.Size = new System.Drawing.Size(100, 20);
            this.tx_clie.TabIndex = 7;
            this.tx_clie.TextChanged += new System.EventHandler(this.tx_clie_TextChanged);
            // 
            // bt_salvar
            // 
            this.bt_salvar.Location = new System.Drawing.Point(333, 370);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(75, 23);
            this.bt_salvar.TabIndex = 8;
            this.bt_salvar.Text = "Salvar";
            this.bt_salvar.UseVisualStyleBackColor = true;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(538, 370);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(75, 23);
            this.bt_cancelar.TabIndex = 9;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_salvar);
            this.Controls.Add(this.tx_clie);
            this.Controls.Add(this.combo_pg);
            this.Controls.Add(this.combo_serv);
            this.Controls.Add(this.tx_comp);
            this.Controls.Add(this.lb_tipopg);
            this.Controls.Add(this.lb_servico);
            this.Controls.Add(this.lb_cliente);
            this.Controls.Add(this.lb_computador);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_computador;
        private System.Windows.Forms.Label lb_cliente;
        private System.Windows.Forms.Label lb_servico;
        private System.Windows.Forms.Label lb_tipopg;
        private System.Windows.Forms.TextBox tx_comp;
        private System.Windows.Forms.ComboBox combo_serv;
        private System.Windows.Forms.ComboBox combo_pg;
        private System.Windows.Forms.TextBox tx_clie;
        private System.Windows.Forms.Button bt_salvar;
        private System.Windows.Forms.Button bt_cancelar;
    }
}