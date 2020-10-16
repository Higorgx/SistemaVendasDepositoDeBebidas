namespace Sistema_de_vendas.Telas
{
    partial class AnaComercial
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ListVenda = new System.Windows.Forms.Button();
            this.ListCliente = new System.Windows.Forms.Button();
            this.ListFornecedor = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Análise Comercial";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ListVenda);
            this.groupBox1.Controls.Add(this.ListCliente);
            this.groupBox1.Controls.Add(this.ListFornecedor);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 272);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione uma das opções";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ListVenda
            // 
            this.ListVenda.Location = new System.Drawing.Point(59, 111);
            this.ListVenda.Name = "ListVenda";
            this.ListVenda.Size = new System.Drawing.Size(269, 23);
            this.ListVenda.TabIndex = 2;
            this.ListVenda.Text = "Estatistica Vendas";
            this.ListVenda.UseVisualStyleBackColor = true;
            this.ListVenda.Click += new System.EventHandler(this.ListVenda_Click);
            // 
            // ListCliente
            // 
            this.ListCliente.Location = new System.Drawing.Point(59, 73);
            this.ListCliente.Name = "ListCliente";
            this.ListCliente.Size = new System.Drawing.Size(269, 23);
            this.ListCliente.TabIndex = 1;
            this.ListCliente.Text = "Lista Clientes";
            this.ListCliente.UseVisualStyleBackColor = true;
            this.ListCliente.Click += new System.EventHandler(this.ListCliente_Click);
            // 
            // ListFornecedor
            // 
            this.ListFornecedor.Location = new System.Drawing.Point(59, 35);
            this.ListFornecedor.Name = "ListFornecedor";
            this.ListFornecedor.Size = new System.Drawing.Size(269, 23);
            this.ListFornecedor.TabIndex = 0;
            this.ListFornecedor.Text = "Lista Fornecedores";
            this.ListFornecedor.UseVisualStyleBackColor = true;
            this.ListFornecedor.Click += new System.EventHandler(this.ListFornecedor_Click);
            // 
            // AnaComercial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(431, 399);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "AnaComercial";
            this.Text = "Análise Comercial";
            this.Load += new System.EventHandler(this.AnaComercial_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ListVenda;
        private System.Windows.Forms.Button ListCliente;
        private System.Windows.Forms.Button ListFornecedor;
    }
}