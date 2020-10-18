using Sistema_de_vendas.DAO;
using Sistema_de_vendas.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_vendas.Telas
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            //cliente.idcliente = Convert.ToInt32(txtidcliente.Text);//
            cliente.nome = (txtnomecliente.Text);
            cliente.rg = (txtRG.Text);
            cliente.cpf = (txtCPF.Text);
            cliente.endereço = (txtEndereco.Text);
            cliente.telefone = (txtTelefone.Text);
            ClienteDAO.salvar(cliente);
            MessageBox.Show("Cliente cadastrado com sucesso!", "Cliente");
        }
    }
}
