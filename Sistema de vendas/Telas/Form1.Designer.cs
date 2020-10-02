namespace Sistema_de_vendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_cad = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.labellogin = new System.Windows.Forms.Label();
            this.labelsenha = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.btn_sair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cad
            // 
            this.btn_cad.Location = new System.Drawing.Point(508, 179);
            this.btn_cad.Name = "btn_cad";
            this.btn_cad.Size = new System.Drawing.Size(133, 23);
            this.btn_cad.TabIndex = 0;
            this.btn_cad.Text = "Cadastre-se";
            this.btn_cad.UseVisualStyleBackColor = true;
            this.btn_cad.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_login
            // 
            this.btn_login.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_login.Location = new System.Drawing.Point(333, 179);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(133, 23);
            this.btn_login.TabIndex = 1;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            // 
            // labellogin
            // 
            this.labellogin.AutoSize = true;
            this.labellogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellogin.Location = new System.Drawing.Point(199, 93);
            this.labellogin.Name = "labellogin";
            this.labellogin.Size = new System.Drawing.Size(57, 24);
            this.labellogin.TabIndex = 2;
            this.labellogin.Text = "Login";
            // 
            // labelsenha
            // 
            this.labelsenha.AutoSize = true;
            this.labelsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsenha.Location = new System.Drawing.Point(191, 133);
            this.labelsenha.Name = "labelsenha";
            this.labelsenha.Size = new System.Drawing.Size(65, 24);
            this.labelsenha.TabIndex = 3;
            this.labelsenha.Text = "Senha";
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(275, 137);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(366, 20);
            this.txt_senha.TabIndex = 4;
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(275, 98);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(366, 20);
            this.txt_login.TabIndex = 5;
            // 
            // btn_sair
            // 
            this.btn_sair.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_sair.Location = new System.Drawing.Point(508, 237);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(133, 23);
            this.btn_sair.TabIndex = 6;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 294);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.labelsenha);
            this.Controls.Add(this.labellogin);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_cad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cad;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label labellogin;
        private System.Windows.Forms.Label labelsenha;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

