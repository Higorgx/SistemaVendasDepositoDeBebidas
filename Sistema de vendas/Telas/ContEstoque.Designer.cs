namespace Sistema_de_vendas.Telas
{
    partial class ContEstoque
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
            this.listEstoque = new System.Windows.Forms.DataGridView();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Desc = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Marca = new System.Windows.Forms.TextBox();
            this.txt_Valunit = new System.Windows.Forms.TextBox();
            this.txt_Qntde = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qntde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.listEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // listEstoque
            // 
            this.listEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.descr,
            this.nome,
            this.marca,
            this.Valunit,
            this.Qntde});
            this.listEstoque.Location = new System.Drawing.Point(12, 12);
            this.listEstoque.Name = "listEstoque";
            this.listEstoque.Size = new System.Drawing.Size(804, 334);
            this.listEstoque.TabIndex = 0;
            this.listEstoque.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.Location = new System.Drawing.Point(718, 521);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_Atualizar.TabIndex = 1;
            this.btn_Atualizar.Text = "atualizar";
            this.btn_Atualizar.UseVisualStyleBackColor = true;
            this.btn_Atualizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(450, 521);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Inserir ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txt_Desc
            // 
            this.txt_Desc.Location = new System.Drawing.Point(22, 368);
            this.txt_Desc.Name = "txt_Desc";
            this.txt_Desc.Size = new System.Drawing.Size(308, 20);
            this.txt_Desc.TabIndex = 3;
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(23, 422);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(307, 20);
            this.txt_Nome.TabIndex = 4;
            // 
            // txt_Marca
            // 
            this.txt_Marca.Location = new System.Drawing.Point(22, 472);
            this.txt_Marca.Name = "txt_Marca";
            this.txt_Marca.Size = new System.Drawing.Size(170, 20);
            this.txt_Marca.TabIndex = 5;
            // 
            // txt_Valunit
            // 
            this.txt_Valunit.Location = new System.Drawing.Point(22, 523);
            this.txt_Valunit.Name = "txt_Valunit";
            this.txt_Valunit.Size = new System.Drawing.Size(170, 20);
            this.txt_Valunit.TabIndex = 6;
            // 
            // txt_Qntde
            // 
            this.txt_Qntde.Location = new System.Drawing.Point(215, 523);
            this.txt_Qntde.Name = "txt_Qntde";
            this.txt_Qntde.Size = new System.Drawing.Size(170, 20);
            this.txt_Qntde.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 507);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Valor Unitário";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 507);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Qntde";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(718, 453);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // descr
            // 
            this.descr.HeaderText = "Descrição";
            this.descr.Name = "descr";
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            // 
            // marca
            // 
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            // 
            // Valunit
            // 
            this.Valunit.HeaderText = "Valor Unitário";
            this.Valunit.Name = "Valunit";
            // 
            // Qntde
            // 
            this.Qntde.HeaderText = "Qntde";
            this.Qntde.Name = "Qntde";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(378, 368);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(308, 20);
            this.txt_id.TabIndex = 14;
            // 
            // ContEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(828, 567);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Qntde);
            this.Controls.Add(this.txt_Valunit);
            this.Controls.Add(this.txt_Marca);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.txt_Desc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Atualizar);
            this.Controls.Add(this.listEstoque);
            this.Name = "ContEstoque";
            this.Text = "ContEstoque";
            this.Load += new System.EventHandler(this.ContEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listEstoque;
        private System.Windows.Forms.Button btn_Atualizar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_Desc;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Marca;
        private System.Windows.Forms.TextBox txt_Valunit;
        private System.Windows.Forms.TextBox txt_Qntde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descr;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valunit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qntde;
        private System.Windows.Forms.TextBox txt_id;
    }
}