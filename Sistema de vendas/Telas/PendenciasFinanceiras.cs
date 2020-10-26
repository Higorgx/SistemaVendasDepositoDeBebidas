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
    public partial class PendenciasFinanceiras : Form
    {
        public PendenciasFinanceiras()
        {
            InitializeComponent();

            var items = new RelatorioPendencias();

            items.relatorio();

            //Listando os itens que estão sendo retornados na lista do RelatórioCliente
            foreach (var venda in items.dados)
            {
                listView1.Items.Add(venda);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
