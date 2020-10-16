using Sistema_de_vendas.DAO;
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
    public partial class ListFornecedores : Form
    {
        public ListFornecedores()
        {
            InitializeComponent();
            mostraFornecedores();
        }

        public void mostraFornecedores()
        {
            var fornecedores = FornecedorDao.retornarTudo();
            int i = 1;
            foreach (var fornecedor in fornecedores)
            {
                ListViewItem item = new ListViewItem(i++.ToString());
                item.SubItems.Add(fornecedor.Cnpj);
                item.SubItems.Add(fornecedor.Nome);
                item.SubItems.Add(fornecedor.Endereço);
                item.SubItems.Add(fornecedor.Ramo);
                listFornecedor.Items.Add(item);
            }
        }

        private void listFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
