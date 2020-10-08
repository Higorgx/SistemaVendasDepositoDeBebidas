using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Sistema_de_vendas.DAL;
using Sistema_de_vendas.DAO;
using Sistema_de_vendas.Modelos;
using System.Text.RegularExpressions;

namespace Sistema_de_vendas.Telas
{
    public partial class Cad : Form
    {
        public Cad()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txt_email.Text;
            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");            if (rg.IsMatch(email))
            {

                if (txt_senha.Text == txt_confirmasenha.Text)
                {

                    Usuario usuario = new Usuario(txt_email.Text, txt_senha.Text);
                    if (usuario.validar())
                    {

                        UsuarioDao.salvar(usuario);
                        MessageBox.Show("Usuario registrado com sucesso!");

                    }
                    else
                    {
                        MessageBox.Show("Falha ao registrar fornecedor... Verifique os dados no formulário!");
                    }
                }

                else
                {
                    MessageBox.Show("As senhas Estão diferentes ");
                }
            }
            else
            {
                MessageBox.Show("Email Inválido!");

 
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labellogin_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Fechar?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                this.Close();
        }

        private void Cad_Load(object sender, EventArgs e)
        {

        }
    }
}
