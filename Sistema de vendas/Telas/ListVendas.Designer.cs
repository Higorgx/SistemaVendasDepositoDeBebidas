namespace Sistema_de_vendas.Telas
{
    partial class ListVendas
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
            this.valorTotVendas = new System.Windows.Forms.TextBox();
            this.totVendas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listVenda = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista das Vendas";
            // 
            // valorTotVendas
            // 
            this.valorTotVendas.Location = new System.Drawing.Point(668, 346);
            this.valorTotVendas.Name = "valorTotVendas";
            this.valorTotVendas.Size = new System.Drawing.Size(106, 20);
            this.valorTotVendas.TabIndex = 2;
            // 
            // totVendas
            // 
            this.totVendas.Location = new System.Drawing.Point(668, 409);
            this.totVendas.Name = "totVendas";
            this.totVendas.Size = new System.Drawing.Size(106, 20);
            this.totVendas.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(643, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total de vendas R$:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(615, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numero total de vendas:";
            // 
            // listVenda
            // 
            this.listVenda.HideSelection = false;
            this.listVenda.Location = new System.Drawing.Point(23, 89);
            this.listVenda.Name = "listVenda";
            this.listVenda.Size = new System.Drawing.Size(756, 219);
            this.listVenda.TabIndex = 6;
            this.listVenda.UseCompatibleStateImageBehavior = false;
            this.listVenda.SelectedIndexChanged += new System.EventHandler(this.listVenda_SelectedIndexChanged_1);
            // 
            // ListVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listVenda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totVendas);
            this.Controls.Add(this.valorTotVendas);
            this.Controls.Add(this.label1);
            this.Name = "ListVendas";
            this.Text = "Lista de Vendas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox valorTotVendas;
        private System.Windows.Forms.TextBox totVendas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listVenda;
    }
}