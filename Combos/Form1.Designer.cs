namespace Combos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Outros = new System.Windows.Forms.Label();
            this.txt_nomeCombo = new System.Windows.Forms.TextBox();
            this.txt_outros = new System.Windows.Forms.TextBox();
            this.cb_bebidasAlcoolicas = new System.Windows.Forms.ComboBox();
            this.cb_bebidasNaoAlcolicas = new System.Windows.Forms.ComboBox();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Combos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bebidas Alcoolicas";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bebidas não alcoolicas";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Outros
            // 
            this.Outros.AutoSize = true;
            this.Outros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outros.Location = new System.Drawing.Point(138, 158);
            this.Outros.Name = "Outros";
            this.Outros.Size = new System.Drawing.Size(63, 20);
            this.Outros.TabIndex = 4;
            this.Outros.Text = "Outros";
            // 
            // txt_nomeCombo
            // 
            this.txt_nomeCombo.Location = new System.Drawing.Point(207, 42);
            this.txt_nomeCombo.Name = "txt_nomeCombo";
            this.txt_nomeCombo.Size = new System.Drawing.Size(368, 20);
            this.txt_nomeCombo.TabIndex = 9;
            // 
            // txt_outros
            // 
            this.txt_outros.Location = new System.Drawing.Point(207, 158);
            this.txt_outros.Name = "txt_outros";
            this.txt_outros.Size = new System.Drawing.Size(368, 20);
            this.txt_outros.TabIndex = 10;
            // 
            // cb_bebidasAlcoolicas
            // 
            this.cb_bebidasAlcoolicas.FormattingEnabled = true;
            this.cb_bebidasAlcoolicas.Location = new System.Drawing.Point(207, 84);
            this.cb_bebidasAlcoolicas.Name = "cb_bebidasAlcoolicas";
            this.cb_bebidasAlcoolicas.Size = new System.Drawing.Size(368, 21);
            this.cb_bebidasAlcoolicas.TabIndex = 11;
            // 
            // cb_bebidasNaoAlcolicas
            // 
            this.cb_bebidasNaoAlcolicas.FormattingEnabled = true;
            this.cb_bebidasNaoAlcolicas.Location = new System.Drawing.Point(207, 122);
            this.cb_bebidasNaoAlcolicas.Name = "cb_bebidasNaoAlcolicas";
            this.cb_bebidasNaoAlcolicas.Size = new System.Drawing.Size(368, 21);
            this.cb_bebidasNaoAlcolicas.TabIndex = 12;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(500, 184);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(75, 23);
            this.btn_adicionar.TabIndex = 13;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 219);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.cb_bebidasNaoAlcolicas);
            this.Controls.Add(this.cb_bebidasAlcoolicas);
            this.Controls.Add(this.txt_outros);
            this.Controls.Add(this.txt_nomeCombo);
            this.Controls.Add(this.Outros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Outros;
        private System.Windows.Forms.TextBox txt_nomeCombo;
        private System.Windows.Forms.TextBox txt_outros;
        private System.Windows.Forms.ComboBox cb_bebidasAlcoolicas;
        private System.Windows.Forms.ComboBox cb_bebidasNaoAlcolicas;
        private System.Windows.Forms.Button btn_adicionar;
    }
}

