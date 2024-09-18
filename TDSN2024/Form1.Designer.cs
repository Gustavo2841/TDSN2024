namespace TDSN2024
{
    partial class Form1
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
            this.lblForma = new System.Windows.Forms.Label();
            this.cmbForma = new System.Windows.Forms.ComboBox();
            this.lblTriangulo = new System.Windows.Forms.Label();
            this.cmbTriangulo = new System.Windows.Forms.ComboBox();
            this.btnCriar = new System.Windows.Forms.Button();
            this.cmbObjetos = new System.Windows.Forms.ComboBox();
            this.lblRaio = new System.Windows.Forms.Label();
            this.txtRaio = new System.Windows.Forms.TextBox();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.lblLado = new System.Windows.Forms.Label();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.lblBase = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblForma
            // 
            this.lblForma.AutoSize = true;
            this.lblForma.Location = new System.Drawing.Point(15, 51);
            this.lblForma.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblForma.Name = "lblForma";
            this.lblForma.Size = new System.Drawing.Size(55, 20);
            this.lblForma.TabIndex = 0;
            this.lblForma.Text = "Forma";
            // 
            // cmbForma
            // 
            this.cmbForma.FormattingEnabled = true;
            this.cmbForma.Items.AddRange(new object[] {
            "Circunferência",
            "Quadrado",
            "Retangulo",
            "Triângulo"});
            this.cmbForma.Location = new System.Drawing.Point(104, 46);
            this.cmbForma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbForma.Name = "cmbForma";
            this.cmbForma.Size = new System.Drawing.Size(187, 28);
            this.cmbForma.TabIndex = 1;
            this.cmbForma.SelectedIndexChanged += new System.EventHandler(this.cmbForma_SelectedIndexChanged);
            // 
            // lblTriangulo
            // 
            this.lblTriangulo.AutoSize = true;
            this.lblTriangulo.Location = new System.Drawing.Point(368, 23);
            this.lblTriangulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTriangulo.Name = "lblTriangulo";
            this.lblTriangulo.Size = new System.Drawing.Size(74, 20);
            this.lblTriangulo.TabIndex = 2;
            this.lblTriangulo.Text = "Triângulo";
            // 
            // cmbTriangulo
            // 
            this.cmbTriangulo.FormattingEnabled = true;
            this.cmbTriangulo.Items.AddRange(new object[] {
            "Equilátero",
            "Isósceles",
            "Reto"});
            this.cmbTriangulo.Location = new System.Drawing.Point(453, 18);
            this.cmbTriangulo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbTriangulo.Name = "cmbTriangulo";
            this.cmbTriangulo.Size = new System.Drawing.Size(180, 28);
            this.cmbTriangulo.TabIndex = 3;
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(480, 326);
            this.btnCriar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(154, 35);
            this.btnCriar.TabIndex = 4;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // cmbObjetos
            // 
            this.cmbObjetos.FormattingEnabled = true;
            this.cmbObjetos.Location = new System.Drawing.Point(453, 74);
            this.cmbObjetos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbObjetos.Name = "cmbObjetos";
            this.cmbObjetos.Size = new System.Drawing.Size(180, 28);
            this.cmbObjetos.TabIndex = 5;
            this.cmbObjetos.SelectedIndexChanged += new System.EventHandler(this.cmbObjetos_SelectedIndexChanged);
            // 
            // lblRaio
            // 
            this.lblRaio.AutoSize = true;
            this.lblRaio.Location = new System.Drawing.Point(18, 143);
            this.lblRaio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRaio.Name = "lblRaio";
            this.lblRaio.Size = new System.Drawing.Size(42, 20);
            this.lblRaio.TabIndex = 6;
            this.lblRaio.Text = "Raio";
            // 
            // txtRaio
            // 
            this.txtRaio.ForeColor = System.Drawing.SystemColors.Window;
            this.txtRaio.Location = new System.Drawing.Point(70, 138);
            this.txtRaio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRaio.Name = "txtRaio";
            this.txtRaio.Size = new System.Drawing.Size(265, 26);
            this.txtRaio.TabIndex = 7;
            this.txtRaio.TextChanged += new System.EventHandler(this.txtRaio_TextChanged);
            // 
            // txtLado
            // 
            this.txtLado.ForeColor = System.Drawing.SystemColors.Window;
            this.txtLado.Location = new System.Drawing.Point(70, 192);
            this.txtLado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(265, 26);
            this.txtLado.TabIndex = 9;
            this.txtLado.TextChanged += new System.EventHandler(this.txtLado_TextChanged);
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.Location = new System.Drawing.Point(15, 192);
            this.lblLado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(45, 20);
            this.lblLado.TabIndex = 8;
            this.lblLado.Text = "Lado";
            // 
            // txtBase
            // 
            this.txtBase.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBase.Location = new System.Drawing.Point(70, 245);
            this.txtBase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(265, 26);
            this.txtBase.TabIndex = 11;
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(15, 249);
            this.lblBase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(46, 20);
            this.lblBase.TabIndex = 10;
            this.lblBase.Text = "Base";
            // 
            // txtAltura
            // 
            this.txtAltura.ForeColor = System.Drawing.SystemColors.Window;
            this.txtAltura.Location = new System.Drawing.Point(70, 302);
            this.txtAltura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(265, 26);
            this.txtAltura.TabIndex = 13;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(15, 306);
            this.lblAltura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(51, 20);
            this.lblAltura.TabIndex = 12;
            this.lblAltura.Text = "Altura";
            // 
            // txtArea
            // 
            this.txtArea.ForeColor = System.Drawing.SystemColors.Window;
            this.txtArea.Location = new System.Drawing.Point(453, 138);
            this.txtArea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(265, 26);
            this.txtArea.TabIndex = 15;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(382, 138);
            this.lblArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(43, 20);
            this.lblArea.TabIndex = 14;
            this.lblArea.Text = "Área";
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPerimetro.Location = new System.Drawing.Point(453, 192);
            this.txtPerimetro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.ReadOnly = true;
            this.txtPerimetro.Size = new System.Drawing.Size(265, 26);
            this.txtPerimetro.TabIndex = 17;
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(364, 197);
            this.lblPerimetro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(77, 20);
            this.lblPerimetro.TabIndex = 16;
            this.lblPerimetro.Text = "Perímetro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(860, 380);
            this.Controls.Add(this.txtPerimetro);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.txtLado);
            this.Controls.Add(this.lblLado);
            this.Controls.Add(this.txtRaio);
            this.Controls.Add(this.lblRaio);
            this.Controls.Add(this.cmbObjetos);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.cmbTriangulo);
            this.Controls.Add(this.lblTriangulo);
            this.Controls.Add(this.cmbForma);
            this.Controls.Add(this.lblForma);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblForma;
        private System.Windows.Forms.ComboBox cmbForma;
        private System.Windows.Forms.Label lblTriangulo;
        private System.Windows.Forms.ComboBox cmbTriangulo;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.ComboBox cmbObjetos;
        private System.Windows.Forms.Label lblRaio;
        private System.Windows.Forms.TextBox txtRaio;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.Label lblPerimetro;
    }
}

