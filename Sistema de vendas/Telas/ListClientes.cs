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
using Sistema_de_vendas.Class;

namespace Sistema_de_vendas.Telas
{
    public partial class ListClientes : Form
    {
        public ListClientes()
        {
            InitializeComponent();

            var items = new RelatorioCliente();

            //Listando os itens que estão sendo retornados na lista do RelatórioCliente
            foreach (var cliente in items.mostrarLista())
            {
                listCliente.Items.Add(cliente);
            }
        }

        private void listCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
