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
    public partial class AnaComercial : Form
    {
        public AnaComercial()
        {
            InitializeComponent();
        }

        private void AnaComercial_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ListFornecedor_Click(object sender, EventArgs e)
        {
            new ListFornecedores().ShowDialog();
        }

        private void ListCliente_Click(object sender, EventArgs e)
        {
            new ListClientes().ShowDialog();
        }

        private void ListVenda_Click(object sender, EventArgs e)
        {
            new ListVendas().ShowDialog();
        }
    }
}
