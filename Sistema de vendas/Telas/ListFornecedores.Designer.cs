namespace Sistema_de_vendas.Telas
{
    partial class ListFornecedores
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
            this.listFornecedor = new System.Windows.Forms.ListView();
            this.CNPJ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NOME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ENDEREÇO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RAMO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SEQ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Fornecedores";
            // 
            // listFornecedor
            // 
            this.listFornecedor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SEQ,
            this.CNPJ,
            this.NOME,
            this.ENDEREÇO,
            this.RAMO});
            this.listFornecedor.HideSelection = false;
            this.listFornecedor.Location = new System.Drawing.Point(12, 106);
            this.listFornecedor.Name = "listFornecedor";
            this.listFornecedor.Size = new System.Drawing.Size(776, 332);
            this.listFornecedor.TabIndex = 1;
            this.listFornecedor.UseCompatibleStateImageBehavior = false;
            this.listFornecedor.View = System.Windows.Forms.View.Details;
            this.listFornecedor.SelectedIndexChanged += new System.EventHandler(this.listFornecedor_SelectedIndexChanged);
            // 
            // CNPJ
            // 
            this.CNPJ.Text = "CNPJ";
            this.CNPJ.Width = 200;
            // 
            // NOME
            // 
            this.NOME.Text = "NOME";
            this.NOME.Width = 200;
            // 
            // ENDEREÇO
            // 
            this.ENDEREÇO.Text = "ENDEREÇO";
            this.ENDEREÇO.Width = 200;
            // 
            // RAMO
            // 
            this.RAMO.Text = "RAMO";
            this.RAMO.Width = 200;
            // 
            // SEQ
            // 
            this.SEQ.Text = "#";
            this.SEQ.Width = 25;
            // 
            // ListFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listFornecedor);
            this.Controls.Add(this.label1);
            this.Name = "ListFornecedores";
            this.Text = "Lista de Fornecedores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listFornecedor;
        private System.Windows.Forms.ColumnHeader CNPJ;
        private System.Windows.Forms.ColumnHeader NOME;
        private System.Windows.Forms.ColumnHeader ENDEREÇO;
        public System.Windows.Forms.ColumnHeader RAMO;
        private System.Windows.Forms.ColumnHeader SEQ;
    }
}