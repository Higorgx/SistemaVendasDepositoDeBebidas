namespace Sistema_de_vendas.Telas
{
    partial class ListClientes
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
            this.listCliente = new System.Windows.Forms.ListView();
            this.NOME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QTD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RG = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CPF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ENDERECO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TELEFONE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Clientes";
            // 
            // listCliente
            // 
            this.listCliente.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.QTD,
            this.NOME,
            this.RG,
            this.CPF,
            this.ENDERECO,
            this.TELEFONE});
            this.listCliente.HideSelection = false;
            this.listCliente.Location = new System.Drawing.Point(12, 105);
            this.listCliente.Name = "listCliente";
            this.listCliente.Size = new System.Drawing.Size(776, 333);
            this.listCliente.TabIndex = 1;
            this.listCliente.UseCompatibleStateImageBehavior = false;
            this.listCliente.View = System.Windows.Forms.View.Details;
            this.listCliente.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // NOME
            // 
            this.NOME.Text = "NOME";
            this.NOME.Width = 180;
            // 
            // QTD
            // 
            this.QTD.Text = "#";
            this.QTD.Width = 26;
            // 
            // RG
            // 
            this.RG.Text = "RG";
            this.RG.Width = 99;
            // 
            // CPF
            // 
            this.CPF.Text = "CPF";
            this.CPF.Width = 150;
            // 
            // ENDERECO
            // 
            this.ENDERECO.Text = "ENDEREÇO";
            this.ENDERECO.Width = 180;
            // 
            // TELEFONE
            // 
            this.TELEFONE.Text = "TELEFONE";
            this.TELEFONE.Width = 200;
            // 
            // ListClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listCliente);
            this.Controls.Add(this.label1);
            this.Name = "ListClientes";
            this.Text = "Lista de Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listCliente;
        private System.Windows.Forms.ColumnHeader NOME;
        private System.Windows.Forms.ColumnHeader QTD;
        private System.Windows.Forms.ColumnHeader RG;
        private System.Windows.Forms.ColumnHeader CPF;
        private System.Windows.Forms.ColumnHeader ENDERECO;
        private System.Windows.Forms.ColumnHeader TELEFONE;
    }
}