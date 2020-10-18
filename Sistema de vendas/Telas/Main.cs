using Sistema_de_vendas.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_vendas.DAO;
using Sistema_de_vendas.Modelos;

namespace Sistema_de_vendas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Cad newCad = new Cad();
            newCad.ShowDialog();
        }

        private void btn_sair_Click_1(object sender, EventArgs e)
        {
            InitializeComponent();

            if (MessageBox.Show("Deseja Fechar?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            new HistoricoDeVendas().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new CadFornecedores().ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                if(UsuarioDao.buscar($"login = '{txt_login.Text}'")[0].Senha == txt_senha.Text)
                {
                    groupBox1.Visible = true;
                    groupBox1.Enabled = true;
                } else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Senha ou login incorretos!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new ContEstoque().ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        /* Chama tela para Análise Comercial */
        private void button9_Click(object sender, EventArgs e)
        {
            new AnaComercial().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmVendas frmVendas = new frmVendas();

            frmVendas.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmCadastroPendencia frmCadastroPendencia = new frmCadastroPendencia();


        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmCliente frmCliente = new frmCliente();
            frmCliente.ShowDialog();
        }
    }
}
